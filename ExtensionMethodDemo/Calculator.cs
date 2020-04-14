using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
   
   public class Calculator // here access modifier is public
    {
        // Addition function

        public double ADD( double num1, double num2)
        {
            return num1 + num2;
        }

        // Subtraction function
        public double SUB(double num1, double num2)
        {
            return num1 - num2;
        }

    }
}
