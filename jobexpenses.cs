using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class jobexpenses
    {
        static void Main(string[] args)
        {
            int amountOfNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[amountOfNumbers];
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).Take(numbers.Length).ToArray();
            int totalExpenses = 0;

            foreach (int number in numbers)
            {
                if (number < 0)
                    totalExpenses += Math.Abs(number);
            }

            Console.WriteLine(totalExpenses);
            Console.ReadLine();
        }
    }
}
