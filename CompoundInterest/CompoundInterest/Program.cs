using System;

namespace CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            double nInvestment;
            double nInterest;
            int nYears;
            double nCompoundInterest = 0;

            Console.Write("Please enter the investment amount: ");
            nInvestment = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the Interest Rate: ");
            nInterest = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Please enter number of Years: ");
            nYears = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= nYears; i++)
            {
                nCompoundInterest = nInvestment * Math.Pow((1 + nInterest), nYears);
            }

            {
                Console.WriteLine("The compound interest is: $", nCompoundInterest);
            }
            Console.ReadLine();
        }
    }
}
