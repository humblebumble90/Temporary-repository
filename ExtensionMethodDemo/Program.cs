using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    public static class CalculatorExtensions
    {
        public static double MPY(this Calculator cal,  double num1, double num2)
        {
            return num1 * num2;
        }

        public static string Greetings(this Calculator cal)
        {
            return "Welcome to Extension methods";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();

            Console.WriteLine($" Sum : {cal.ADD(4, 5)}");

            Console.WriteLine($" Diff : {cal.SUB(14, 8)}");

           Console.WriteLine($" Multiply : {cal.MPY(14, 8)}");

            Console.WriteLine($" Greetings : {cal.Greetings()}");
        }
    }
}
