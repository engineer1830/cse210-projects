using System;

// Enhancement added to prompt entry of scripture reference and text so that the user is able to input any desired scripture

class Program
{
    static void Main(string[] args)
    {
        // Hard coding commented out . . . enhancement enables the user to input desired scripture

        // Reference reference = new Reference("Proverbs", 3, 5, 6);

        // string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
        // Scripture scripture = new Scripture(reference, text);

        Console.Write("Enter the book: ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Enter the start verse: ");
        int startVerse = int.Parse(Console.ReadLine());

        Console.Write("Enter the end verse (or press Enter for single verse): ");
        string endInput = Console.ReadLine();

        int endVerse;
        Reference reference;

        if (string.IsNullOrWhiteSpace(endInput))
        {
            reference = new Reference(book, chapter, startVerse);
        }
        else
        {
            endVerse = int.Parse(endInput);
            reference = new Reference(book, chapter, startVerse, endVerse);
        }

        Console.Write("Enter the scripture text: ");
        string text = Console.ReadLine();

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsFullyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}