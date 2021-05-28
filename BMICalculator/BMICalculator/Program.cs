using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your weight in pounds: ");
            decimal lb = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your height in inches: ");
            decimal ft = Convert.ToDecimal(Console.ReadLine());

            decimal nBMI = lb / (ft * ft) * 703;
            Console.WriteLine("BMI is " + Math.Round(nBMI, 4));

            Console.ReadLine();
        }
    }
}
