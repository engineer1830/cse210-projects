using System;

using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int number = 1;

        // Building the list

        while (number != 0)
        {
            Console.Write("Enter a list of numbers.  Enter 0 when finished. ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        //  Calculating the total

        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }

        Console.WriteLine($"The sum is: {sum} ");

        // Calculating the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        // Finding the max of the list
        int max = numbers[0];

        foreach (int member in numbers)
        {
            if (member > max)
            {
                max = member;
            }
        }

        Console.WriteLine($"The maximum number is: {max} ");
    }
}