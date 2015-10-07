using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1NS
{
   public class Problem1
   {
      private int _startNumber;
      private int _endNumber;
      private string _stringForDivBy3;
      private string _stringForDivBy5;

      public Problem1(int startNumber, int endNumber, string stringForDivBy3, string stringForDivBy5)
      {
         _startNumber = startNumber;
         _endNumber = endNumber;
         _stringForDivBy3 = stringForDivBy3;
         _stringForDivBy5 = stringForDivBy5;
      }

      public void printOutput()
      {
         string output = "";
         if (_startNumber <= _endNumber)
         {
            output += chooseString(_startNumber);
            for (int i = _startNumber + 1; i <= _endNumber; i++)
            {
               output += " ";
               output += chooseString(i);
            }
         }
         else
         {
            output += "Invalid Range.";
         }
         Console.WriteLine(output);
      }

      public string chooseString(int value)
      {
         string choice = "";
         if (value % 3 == 0)
         {
            choice += _stringForDivBy3;
         }
         if (value % 5 == 0)
         {
            choice += _stringForDivBy5;
         }
         if (value % 3 != 0 && value % 5 != 0)
         {
            choice += value.ToString();
         }

         return choice;
      }
   }
}
