using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double nBaseWidth, nArea, nHeight;

            Console.Write("Please enter the base-width of your triangle: ");
            nBaseWidth = double.Parse(Console.ReadLine());

            Console.Write("Please enter the height of your triangle :");
            nHeight = double.Parse(Console.ReadLine());

            nArea = (nBaseWidth * nHeight) / 2;

            Console.WriteLine("The area of yor triangle is " + nArea);

            Console.Read();
        }
    }
}