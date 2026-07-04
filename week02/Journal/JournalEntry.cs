using System;

public class JournalEntry
{
    public DateTime _date;
    public string _prompt;
    public string _content;
    

    public void Display()
    {
        Console.WriteLine($"{_date.ToShortDateString()}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine(_content);
        Console.WriteLine();

    }
}