using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problem1NS;

namespace QuadrusDeveloperPracticum
{
   class Program
   {
      static void Main(string[] args)
      {
         Problem1 p1 = new Problem1(1, 100, "Pip", "Pop");
         p1.printOutput();

         Console.WriteLine("\nPress any key to exit");
         Console.ReadKey();
      }
   }
}
