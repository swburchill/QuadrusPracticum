using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Problem3NS;

namespace QuadrusDeveloperPracticumTest
{
   [TestClass]
   public class Problem3Test
   {
      [TestMethod]
      public void addFirstNodeAsHead()
      {
         //arange
         Problem3 p3 = new Problem3();
         Node notExpected = null;
         int expectedCount = 1;
         
         //act
         Node actual = p3.addNode(1, p3._head);
         Node expected = p3._head;

         //assert
         Assert.AreNotEqual(notExpected, actual, "Node not added as head");
         Assert.AreEqual(expected, actual, "Node not added as head");
         Assert.AreEqual(expectedCount, p3.nodeCount, "Node not added to tree");
      }

      [TestMethod]
      public void addSecondNodeAsFirstChildToHead()
      {
         Problem3 p3 = new Problem3();
         p3.addNode(2, p3._head);
         Node notExpected = null;
         Node nodeBeforeAssignment = p3._head.children[0];
         int expectedCount = 2;

         Node actual = p3.addNode(1, p3._head);
         Node expected = p3._head.children[0];

         Assert.AreNotEqual(notExpected, actual, "Node not added");
         Assert.AreNotEqual(nodeBeforeAssignment, actual, "Node not added as first child");
         Assert.AreEqual(expected, actual, "Node not added as first child");
         Assert.AreEqual(expectedCount, p3.nodeCount, "Node not added to tree");
      }

      [TestMethod]
      public void addThirdNodeAsSecondChildToHead()
      {
         Problem3 p3 = new Problem3();
         p3.addNode(2, p3._head);
         p3.addNode(3, p3._head);
         Node notExpected = null;
         Node nodeBeforeAssignment = p3._head.children[1];
         int expectedCount = 3;

         Node actual = p3.addNode(1, p3._head);
         Node expected = p3._head.children[1];

         Assert.AreNotEqual(notExpected, actual, "Node not added");
         Assert.AreNotEqual(nodeBeforeAssignment, actual, "Node not added as second child");
         Assert.AreEqual(expected, actual, "Node not added as second child");
         Assert.AreEqual(expectedCount, p3.nodeCount, "Node not added to tree");
      }

      [TestMethod]
      public void cannotAddNodesWithValue0()
      {
         Problem3 p3 = new Problem3();
         Node expected = null;
         int expectedCount = 0;

         Node actual = p3.addNode(0, p3._head);

         Assert.AreEqual(expected, actual, "Node wrongly added to tree");
         Assert.AreEqual(expectedCount, p3.nodeCount, "Node wrongly added to tree");
      }

      [TestMethod]
      public void cannotAddNodesWithNegativeValue()
      {
         Problem3 p3 = new Problem3();
         Node expected = null;
         int expectedCount = 0;

         Node actual = p3.addNode(-5, p3._head);

         Assert.AreEqual(expected, actual, "Node wrongly added to tree");
         Assert.AreEqual(expectedCount, p3.nodeCount, "Node wrongly added to tree");
      }

      [TestMethod]
      public void countPopulatedChildren()
      {
         Problem3 p3 = new Problem3();
         p3.addNode(5, p3._head);
         p3.addNode(1, p3._head);
         p3.addNode(1, p3._head);
         int expected = 2;

         int actual = p3.countChildren(p3._head);

         Assert.AreEqual(expected, actual, "Improper count of children");
      }

      [TestMethod]
      public void resizeChildredArrayWhenEmpty()
      {
         Problem3 p3 = new Problem3();
         p3.addNode(5, p3._head);
         int expectedCount = 2;
         bool expected = true;

         bool actual = p3.changeNodeValue(2, p3._head);
         int actualCount = p3._head.children.Length;

         Assert.AreEqual(expected, actual, "Resize of children array failed");
         Assert.AreEqual(expectedCount, actualCount, "Children array not resized");
      }

      [TestMethod]
      public void resizePopulatedChildredArrayLargerThanNumberOfChildren()
      {
         Problem3 p3 = new Problem3();
         p3.addNode(5, p3._head);
         Node expectedChild1 = p3.addNode(1, p3._head);
         Node expectedChild2 = p3.addNode(2, p3._head);
         int expectedCount = 3;
         bool expected = true;

         bool actual = p3.changeNodeValue(3, p3._head);
         int actualCount = p3._head.children.Length;
         Node actualChild1 = p3._head.children[0];
         Node actualChild2 = p3._head.children[1];

         Assert.AreEqual(expected, actual, "Resize of children array failed");
         Assert.AreEqual(expectedCount, actualCount, "Children array not resized");
         Assert.AreEqual(expectedChild1, actualChild1, "Children not saved when array resized");
         Assert.AreEqual(expectedChild2, actualChild2, "Children not saved when array resized");
      }

      [TestMethod]
      public void resizePopulatedChildredArrayLessThanNumberOfChildren()
      {
         Problem3 p3 = new Problem3();
         p3.addNode(5, p3._head);
         Node expectedChild1 = p3.addNode(2, p3._head);
         Node expectedChild2 = p3.addNode(4, p3._head);
         Node expectedChild3 = p3.addNode(3, p3._head);
         int expectedCount = 1;
         bool expected = true;

         bool actual = p3.changeNodeValue(1, p3._head);
         int actualCount = p3._head.children.Length;
         Node actualChild1 = p3._head.children[0];
         Node actualChild2 = p3._head.children[0].children[0];
         Node actualChild3 = p3._head.children[0].children[1];

         Assert.AreEqual(expected, actual, "Resize of children array failed");
         Assert.AreEqual(expectedCount, actualCount, "Children array not resized");
         Assert.AreEqual(expectedChild1, actualChild1, "Children not saved when array resized");
         Assert.AreEqual(expectedChild2, actualChild2, "Excess children not saved to next empty child when array resized");
         Assert.AreEqual(expectedChild3, actualChild3, "Excess children not saved to next empty child when array resized");
      }

      [TestMethod]
      public void resizePopulatedChildredArrayToNumberOfChildren()
      {
         Problem3 p3 = new Problem3();
         p3.addNode(5, p3._head);
         Node expectedChild1 = p3.addNode(1, p3._head);
         Node expectedChild2 = p3.addNode(1, p3._head);
         int expectedCount = 2;
         bool expected = true;

         bool actual = p3.changeNodeValue(2, p3._head);
         int actualCount = p3._head.children.Length;
         Node actualChild1 = p3._head.children[0];
         Node actualChild2 = p3._head.children[1];

         Assert.AreEqual(expected, actual, "Resize of children array failed");
         Assert.AreEqual(expectedCount, actualCount, "Children array not resized");
         Assert.AreEqual(expectedChild1, actualChild1, "Children not saved when array resized");
         Assert.AreEqual(expectedChild2, actualChild2, "Children not saved when array resized");
      }

      [TestMethod]
      public void findEmptyChildInCurrentNode()
      {
         Problem3 p3 = new Problem3();
         Node expected = new Node(3);
         p3.addNode(3, p3._head);
         p3.addNode(1, p3._head);
         p3.addNode(2, p3._head);

         Node actual = p3.findEmptyChild(p3._head, expected);
         Node expectedNode = p3._head.children[2];

         Assert.AreEqual(expected, actual, "Empty child not found");
         Assert.AreEqual(expectedNode, actual, "Node not placed in empty child");
      }

      [TestMethod]
      public void findEmptyChildInCurrentNodeChildren()
      {
         Problem3 p3 = new Problem3();
         Node expected = new Node(3);
         p3.addNode(2, p3._head);
         p3.addNode(1, p3._head);
         p3.addNode(1, p3._head);

         Node actual = p3.findEmptyChild(p3._head, expected);
         Node expectedNode = p3._head.children[0].children[0];

         Assert.AreEqual(expected, actual, "Empty child not found");
         Assert.AreEqual(expectedNode, actual, "Node not placed in empty child");
      }

      [TestMethod]
      public void findEmptyChildInCurrentNodeSecondChild()
      {
         Problem3 p3 = new Problem3();
         Node expected = new Node(3);
         p3.addNode(2, p3._head);
         p3.addNode(2, p3._head);
         p3.addNode(1, p3._head);
         p3.addNode(1, p3._head);

         Node actual = p3.findEmptyChild(p3._head, expected);
         Node expectedNode = p3._head.children[0].children[1];    //because we always go down left path

         Assert.AreEqual(expected, actual, "Empty child not found");
         Assert.AreEqual(expectedNode, actual, "Node not placed in empty child");
      }
   }
}
