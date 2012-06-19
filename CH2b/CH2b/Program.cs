using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH2b
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int theSum, theProduct;

            num1 = 3;
            num2 = 5;

            theSum = num1 + num2;
            theProduct = num1 * num2;

            Console.WriteLine("The sum of {0} and {1} is {2}", 
                num1, num2, theSum);
            Console.WriteLine("The product of {0} and {1} is {2}", 
                num1, num2, theProduct);
            Console.ReadLine();
        }
    }
}
