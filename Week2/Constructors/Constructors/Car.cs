using System;

namespace Constructors
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            int number = 10;
            Console.WriteLine("Enter your vehicle Reg. Number");
            registrationNumber = Console.ReadLine();
            Console.WriteLine("Car is being initialized. {0}, {1}", registrationNumber, number);
            Console.ReadLine();
        }
    }
}