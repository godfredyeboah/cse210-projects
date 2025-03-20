using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    // Display the scripture with hidden words
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference);
        Console.WriteLine(string.Join(" ", _words));
    }

    // Hide a few random words that are not already hidden
    public void HideWords(int count = 2)
    {
        List<Word> visibleWords = _words.Where(word => !word.IsHidden).ToList();
        
        if (visibleWords.Count == 0)
            return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
