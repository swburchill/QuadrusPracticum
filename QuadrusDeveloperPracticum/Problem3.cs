using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3NS
{
   public class Node
   {
      public Node[] children;
      public int data;

      public Node(int value)
      {
         data = value;
         children = new Node[value];

         for(int i = 0; i < value; i++)
         {
            children[i] = null;
         }
      }
   }

   public class Problem3
   {
      public Node _head;
      public int nodeCount;

      public Problem3()
      {
         _head = null;
         nodeCount = 0;
      }

      public Node addNode(int value, Node currentNode)
      {
         //do not allow nodes with values less than 1
         if(value < 1)
         {
            return null;
         }

         Node newNode = new Node(value);

         //check head
         if (_head == null)
         {
            _head = newNode;
            nodeCount++;
            return _head;
         }
         //if head not null but current node is, we won't be adding to tree
         else if(currentNode == null)
         {
            return null;
         }

         //find first empty child
         Node emptyChild = findEmptyChild(currentNode, newNode);
         nodeCount++;
         return emptyChild;
      }

      public Node findEmptyChild(Node currentNode, Node newNode)
      {
         //find first empty child of current node
         for (int i = 0; i < currentNode.children.Length; i++)
         {
            if (currentNode.children[i] == null)
            {
               currentNode.children[i] = newNode;
               return currentNode.children[i];
            }
         }
         //move to first child and check it's children for an empty
         //**this causes values to always accumulate on left side of the tree
         Node emptyChild = findEmptyChild(currentNode.children[0], newNode);
         return emptyChild;
      }

      public bool changeNodeValue(int newValue, Node currentNode)
      {
         bool success = false;
         if (newValue < 1)
         {
            return success;
         }

         currentNode.data = newValue;
         Node[] temp = currentNode.children;
         int numberChildren = countChildren(currentNode);

         //if new value >= populated children then just change children array size
         if (newValue >= numberChildren)
         {
            //resize child array
            currentNode.children = new Node[newValue];
            for (int i = 0; i < numberChildren; i++)
            {
               //copy old children over
               currentNode.children[i] = temp[i];
            }
            success = true;
         }
         //number of children outnumber new value, resize array and move excess children down
         else
         {
            //resize child array
            currentNode.children = new Node[newValue];
            for (int i = 0; i < newValue; i++)
            {
               //copy old children over
               currentNode.children[i] = temp[i];
            }
            //for remaining old children, readd them starting from current nodes
            for (int j = newValue; j < numberChildren; j++)
            {
               findEmptyChild(currentNode, temp[j]);
            }
            success = true;
         }
         return success;
      }

      public int countChildren(Node currentNode)
      {
         int count = 0;

         foreach (Node child in currentNode.children)
         {
            if (child != null)
            {
               count++;
            }
         }

         return count;
      }
   }
}
