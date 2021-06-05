using System.ComponentModel;

namespace Methods
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        // Formular for an area of a circle is 2pir2 = value of my area of a circle. 
    }
}