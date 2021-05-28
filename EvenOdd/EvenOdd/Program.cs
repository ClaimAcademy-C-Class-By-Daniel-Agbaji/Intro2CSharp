using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");

            int intNumber = Console.Read();

            if (intNumber % 2 == 0)
                Console.WriteLine("RESULT: Even");
            else
                Console.WriteLine("RESULT: Odd");

                Console.Read();
        }
    }
}
