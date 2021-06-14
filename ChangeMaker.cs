using System;

namespace ChangeMaker1
{
    class Program
    {
        static void Main(string[] args)
        {
            int change;
            string ans = "";


            do
            {
                do
                {
                    Console.Write("Enter your change: ");
                    change = Convert.ToInt32(Console.ReadLine());

                    if (!(change <= 99 && change >= 0))
                    {
                        Console.WriteLine("No can do");
                    }
                } while (!(change <= 99 && change >= 0));


                int quarters = change / 25;
                change %= 25;
                int dimes = change / 10;
                change %= 10;
                int nickels = change / 5;
                int pennies = change - nickels * 5;
                Console.WriteLine("quarters: " + quarters);
                Console.WriteLine("dimes: " + dimes);
                Console.WriteLine("nickels: " + nickels);
                Console.WriteLine("pennies: " + pennies);



            
                Console.Write("Do you want more?");
                ans = Console.ReadLine().ToUpper();
                if (!(ans.Equals("YES") || ans.Equals("Y")))
                {
                    Console.WriteLine("GoodBye");
                }
            } while (ans.Equals("YES")||ans.Equals("Y"));
        }

    }
}
