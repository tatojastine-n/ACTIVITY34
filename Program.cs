using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRootCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
            {
                Console.WriteLine("Error: Please enter a valid positive integer.");
                return;
            }
            while (number >= 10) // Continue until the number is a single digit
            {
                int sum = 0;

                // Sum the digits of the number
                while (number > 0)
                {
                    sum += number % 10; // Get the last digit
                    number /= 10;       // Remove the last digit
                }
                number = sum; // Update number to the sum of its digits
            }
            Console.WriteLine($"Single-digit result: {number}");
        }
    }
}
