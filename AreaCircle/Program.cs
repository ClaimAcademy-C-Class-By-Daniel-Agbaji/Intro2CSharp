using System;

namespace DanWayMondayAssignment
{
    class AreaCircProgram
    {
        static void Main(string[] args)
        {
            double PI = 3.142;
            double nRadius, nArea, nCircumference;

            Console.Write("Please enter the radius of your circle: ");
            nRadius = double.Parse(Console.ReadLine());

            nArea = PI * (nRadius * nRadius);

            Console.WriteLine("The area of your circle is " + nArea);

            nCircumference = (PI * nRadius) * 2;
            Console.WriteLine("The circumference of your circle is " + nCircumference);

            Console.ReadLine();
        }
    }
}
