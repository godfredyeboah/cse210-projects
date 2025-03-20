class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    // Hide the word by replacing it with underscores (_)
    public void Hide()
    {
        IsHidden = true;
    }

    // Display the word (hidden words show underscores)
    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}
