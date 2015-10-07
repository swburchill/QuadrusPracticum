using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2NS
{
   public class Node
   {
      public Node next;
      public Object data;

      public Node(Object value)
      {
         next = null;
         data = value;
      }
   }

   public class Problem2
   {
      private Node _head;
      private Hashtable _values;

      public Problem2()
      {
         _head = null;
         _values = new Hashtable();
      }

      public Object Peek()
      {
         if (_head != null)
         {
            return _head.data;
         }
         else
         {
            return null;
         }
      }

      public void Push(Object value)
      {
         if(!_values.ContainsKey(value))
         {
            _values.Add(value, value);
            Node temp = new Node(value);
            temp.next = _head;
            _head = temp;
         }
      }

      public Object Pop()
      {
         if (_head != null)
         {
            Node temp = _head;
            _head = _head.next;
            temp.next = null;
            _values.Remove(temp.data);

            return temp.data;
         }
         else
         {
            return null;
         }
      }
   }
}
