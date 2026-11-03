
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            string json = JsonSerializer.Serialize(
                _entries,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true
                });

            File.WriteAllText(filename, json);
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to save journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            string json = File.ReadAllText(filename);

            List<Entry> loadedEntries =
                JsonSerializer.Deserialize<List<Entry>>(
                    json,
                    new JsonSerializerOptions
                    {
                        IncludeFields = true
                    }) ?? new List<Entry>();

            _entries = loadedEntries;
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to load journal: {ex.Message}");
        }
    }
}
