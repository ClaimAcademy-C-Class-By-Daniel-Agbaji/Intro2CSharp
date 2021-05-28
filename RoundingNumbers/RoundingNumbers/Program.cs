using System;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number with a decimal: ");

            double nDouble = double.Parse(Console.ReadLine());

            int intNumber = (int) Math.Round(nDouble);

            Console.WriteLine("You entered " + nDouble + ", the new value is " + intNumber);

            Console.ReadLine();
        }
    }
}
