using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    // Constructor to initialize an entry
    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompt;
        _response = response;
    }

    // Method to format the entry for display
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine($"Response: {_response}\n");
    }

    // Method to format the entry for saving to a file
    public string ToFileFormat()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    // Method to create an entry from a file line
    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }
}
