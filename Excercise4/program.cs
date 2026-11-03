
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        if (numbers.Count > 0)
        {
            // Core 1: Calculate the sum
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Core 2: Calculate the average
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Core 3: Find the largest number
            int largest = numbers[0];

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine($"The largest number is: {largest}");

            // Stretch 1: Find smallest positive number
            int smallestPositive = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                }
            }

            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine(
                    $"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers.");
            }

            // Stretch 2: Sort the list
            numbers.Sort();

            Console.WriteLine("The sorted list is:");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
