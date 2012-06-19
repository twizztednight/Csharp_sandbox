using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH5Challenge6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int myNum = int.Parse(Console.ReadLine());

            for (int row = myNum; row >= 1; row--)
            {
                for (int col = row; col >= 1; col--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
