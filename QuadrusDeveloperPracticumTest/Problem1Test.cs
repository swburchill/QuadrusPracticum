using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Problem1NS;

namespace QuadrusDeveloperPracticumTest
{
   [TestClass]
   public class Problem1Test
   {
      [TestMethod]
      public void chooseForNumberDivisibleBy3()
      {
         //arange
         Problem1 p1 = new Problem1(1, 100, "Pip", "Pop");
         string expected = "Pip";

         //act
         string actual = p1.chooseString(6);

         //assert
         Assert.AreEqual(expected, actual, "Wrong output for numbers divisible by 3");
      }

      [TestMethod]
      public void chooseForNumberDivisibleBy5()
      {
         Problem1 p1 = new Problem1(1, 100, "Pip", "Pop");
         string expected = "Pop";

         string actual = p1.chooseString(10);

         Assert.AreEqual(expected, actual, "Wrong output for numbers divisible by 5");
      }

      [TestMethod]
      public void chooseForNumberDivisibleBy3AndBy5()
      {
         Problem1 p1 = new Problem1(1, 100, "Pip", "Pop");
         string expected = "PipPop";

         string actual = p1.chooseString(15);

         Assert.AreEqual(expected, actual, "Wrong output for numbers divisible by 3 and by 5");
      }

      [TestMethod]
      public void chooseForNumberNotDivisibleBy3OrBy5()
      {
         Problem1 p1 = new Problem1(1, 100, "Pip", "Pop");
         string expected = "11";

         string actual = p1.chooseString(11);

         Assert.AreEqual(expected, actual, "Wrong output for numbers not divisible by 3 or by 5");
      }
   }
}
