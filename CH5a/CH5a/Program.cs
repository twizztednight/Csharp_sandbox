using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH5a
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Before the loop!");

            do
            {
                Console.WriteLine("Pass {0} through the loop", i++);

            } while (i < 10);
           
                Console.WriteLine("Pass {0} through the loop", i++);
            
            Console.WriteLine("After the loop!");

            Console.ReadLine();
        }
    }
}
