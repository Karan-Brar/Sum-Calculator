using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumbersProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Enter the first number: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Int32.Parse(Console.ReadLine());

            if(num1 > 0 && num2 > 0)
            {
                int sum = num1 + num2;

                Console.WriteLine($"The sum is {sum}");
            }
            else
            {
                Console.WriteLine("Error: Both the numbers must the greater than zero!");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
