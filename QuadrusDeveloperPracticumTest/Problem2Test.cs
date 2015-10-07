using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Problem2NS;

namespace QuadrusDeveloperPracticumTest
{
   [TestClass]
   public class Problem2Test
   {
      [TestMethod]
      public void peekEmptyList()
      {
         //arange
         Problem2 p2 = new Problem2();
         Object expected = null;

         //act
         Object actual = p2.Peek();

         //assert
         Assert.AreEqual(expected, actual, "Wrong output from peeking empty list");
      }

      [TestMethod]
      public void popEmptyList()
      {
         Problem2 p2 = new Problem2();
         Object expected = null;

         Object actual = p2.Pop();

         Assert.AreEqual(expected, actual, "Wrong output from popping empty list");
      }

      [TestMethod]
      public void valueStillTopAfterPeek()
      {
         Problem2 p2 = new Problem2();
         p2.Push(3);
         p2.Push(2);
         int expected = 2;

         p2.Peek();
         Object actual = p2.Pop();

         Assert.AreEqual(expected, actual, "Wrong output from popping list after peek");
      }

      [TestMethod]
      public void peekValue()
      {
         Problem2 p2 = new Problem2();
         p2.Push(3);
         int expected = 3;

         Object actual = p2.Peek();

         Assert.AreEqual(expected, actual, "Wrong output from peeking list");
      }

      [TestMethod]
      public void popValue()
      {
         Problem2 p2 = new Problem2();
         p2.Push(3);
         int expected = 3;

         Object actual = p2.Pop();

         Assert.AreEqual(expected, actual, "Wrong output from popping list");
      }

      [TestMethod]
      public void duplicateNotPushed()
      {
         Problem2 p2 = new Problem2();
         p2.Push(3);
         p2.Push(2);
         p2.Push(3);
         int expected = 2;

         Object actual = p2.Pop();

         Assert.AreEqual(expected, actual, "Wrong output from pushing duplicate into list");
      }

      [TestMethod]
      public void listEmptyAfterPop()
      {
         Problem2 p2 = new Problem2();
         p2.Push(3);
         Object expected = null;
         p2.Pop();

         Object actual = p2.Pop();

         Assert.AreEqual(expected, actual, "Wrong output from popping empty list");
      }

      [TestMethod]
      public void valueCanBeReAddedIfPopped()
      {
         Problem2 p2 = new Problem2();
         p2.Push(3);
         p2.Push(2);
         p2.Pop();
         p2.Push(2);
         Object expected = 2;

         Object actual = p2.Pop();

         Assert.AreEqual(expected, actual, "Wrong output from pushing duplicate after original popped from list");
      }

      [TestMethod]
      public void poppingFreesNextValueForPop()
      {
         Problem2 p2 = new Problem2();
         p2.Push(3);
         p2.Push(2);
         p2.Pop();
         Object expected = 3;

         Object actual = p2.Pop();

         Assert.AreEqual(expected, actual, "Wrong output from popping list");
      }
   }
}
