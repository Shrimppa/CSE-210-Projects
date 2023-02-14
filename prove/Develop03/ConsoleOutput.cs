using System;

public class ConsoleOutput
{
    private string _verse;

    private string _reference;

    public void GetData()
    {
        Scripture s = new Scripture();

        s.GetScripture();

        string reference = s.GetScriptureReference();

        _reference = reference;
        
        string verse = s.GetScriptureVerse();

        _verse = verse;
    }

    public void Display()
    {
        Word w = new Word();

        w.GiveWords(_verse);

        Console.WriteLine($"Reference:{_reference} Verse:{_verse}");

        _verse = w.Hide();

    }

    public void Clear()
    {
        Console.Clear();
    }
}