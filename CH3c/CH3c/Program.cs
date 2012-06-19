using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH3c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your options are");
            Console.WriteLine(" 1) Coffee");
            Console.WriteLine(" 2) Tea");
            Console.WriteLine(" 3) Hot Chocolate");
            int myChoice = int.Parse(Console.ReadLine());

            Console.Write("Thank you, here is your ");

            switch (myChoice)
            {
                case 1:
                    Console.Write("coffee.");
                    break;

                case 2:
                    Console.Write("tea.");
                    break;

                case 3:
                    Console.Write("hot chocolate.");
                    break;

                default:
                    Console.Write("hot drink.");
                    break;
            }

            Console.WriteLine(" Please enjoy!");

            Console.ReadLine();

        }
    }
}
