using System;

// I have added a couple of enhancements to this program.  First, I added additional prompts beyond those suggested by the program.  I also added the feature to report when the last entry was recorded when a file is loaded.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string promptText = prompt.GetRandomPrompt();
                Console.WriteLine(promptText);

                string response = Console.ReadLine();

                JournalEntry entry = new JournalEntry();
                entry._date = DateTime.Now;
                entry._prompt = promptText;
                entry._content = response;

                journal._entries.Add(entry);
            }

            if (choice == "2")
            {
                journal.Display();
            }
            if (choice == "3")
            {
                Console.WriteLine("Enter filename:");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            if (choice == "4")
            {
                Console.WriteLine("Enter filename:");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);

                DateTime lastDate = journal.GetLastEntryDate();

                if (lastDate == DateTime.MinValue)
                {
                    Console.WriteLine("No entries found in this journal.");
                }
                else
                {
                    Console.WriteLine($"Last entry recorded on: {lastDate.ToShortDateString()}");
                }
            }
            if (choice == "5") break;
        }

    }
}