using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH2c
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, theSum;

            Console.Write("Enter the 1st number: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the 2nd number: ");
            num2 = Int32.Parse(Console.ReadLine());

            theSum = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, theSum);

            Console.ReadLine();
        }
    }
}
