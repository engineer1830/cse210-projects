using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public string _name;
    public List<JournalEntry> _entries = new List<JournalEntry>();


    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Entries:");

        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._content}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            JournalEntry entry = new JournalEntry();
            entry._date = DateTime.Parse(parts[0]);
            entry._prompt = parts[1];
            entry._content = parts[2];

            _entries.Add(entry);
        }
    }

    public DateTime GetLastEntryDate()
    {
        if (_entries.Count == 0)
        {
            return DateTime.MinValue; // signals "no entries"
        }

        DateTime latest = DateTime.MinValue;

        foreach (JournalEntry entry in _entries)
        {
            if (entry._date > latest)
            {
                latest = entry._date;
            }
        }

        return latest;
    }


}