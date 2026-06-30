using System;
using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int g = int.Parse(grade);
        string result;

        if (g >= 90)
        {
            result = "A";
            // Console.WriteLine("Your grade is an A!");
        }

        else if (g >= 80)
        {
            result = "B";
            // Console.WriteLine("Your grade is a B");
        }

        else if (g >= 70)
        {
            result = "C";
            // Console.WriteLine("Your grade is a C");
        }

        else if (g >= 60)
        {
            result = "D";
            // Console.WriteLine("Your grade is a D");
        }

        else
        {
            result = "F";
            // Console.WriteLine("Your grade is a F");
        }

        if (result == "A")
        {
            Console.WriteLine($"Your grade is an {result}");
        }

        else
        {
            Console.WriteLine($"Your grade is a {result}");
        }
        

        if (g >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }

        else
        {
            Console.WriteLine("Please talk with your instructor to determine where you can obtain guidance for your next work.");
        }


    }

}