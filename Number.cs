using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BincomDev_C__Trainee_Test
{
    internal class Number
    {
        public static void NumberGuess()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
            Console.WriteLine("");

            Console.WriteLine("***********************************************************************");


        }


        public static void LoopNumber()
        {
            // Using a for loop to print numbers from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            Console.WriteLine("***********************************************************************");
        }

        public static void IntergerArray()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("***********************************************************************");

        }
    }
}
