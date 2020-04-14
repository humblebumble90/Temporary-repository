using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    public static class IntExtensions
        {
          public static int MultiplyByTwo(this int i)
          {
            return i * 2;
          }

        public static int CountChar(this string str)
        {
            return str.Length;
        }
    } // end 

    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            Console.WriteLine(number1.MultiplyByTwo());

            string name = "Extension Methods";
            Console.WriteLine(name.CountChar());
        }
    }
}
