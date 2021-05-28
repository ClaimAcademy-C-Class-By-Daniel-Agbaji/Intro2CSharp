using System;
using System.Text;

namespace Ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a letter of the alphabet: ");
            string strLetter = Console.ReadLine();
            byte[] asciiValue = Encoding.ASCII.GetBytes(strLetter);

            foreach (var value in asciiValue)
            {
                Console.WriteLine("The ASCII value of " + strLetter + " is " + value);
            }
            Console.Read();
        }
    }
}
