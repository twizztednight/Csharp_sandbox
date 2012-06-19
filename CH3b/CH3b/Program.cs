using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH3b
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = 5, guessNum;

            Console.Write("Guess a number between 0 and 10: ");
            guessNum = Int32.Parse(Console.ReadLine());

            if (secretNum == guessNum)
                Console.WriteLine("Great guess, you win!");
            else
            {
                if (guessNum > secretNum)
                    Console.WriteLine("Sorry, too high!");
                else
                    Console.WriteLine("Sorry, too low!");
            }

            Console.ReadLine();
        }
    }
}
