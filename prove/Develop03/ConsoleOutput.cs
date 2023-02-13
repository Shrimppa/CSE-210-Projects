using System;

public class ConsoleOutput
{
    public void Display()
    {
        Scripture s = new Scripture();
        s.GetScripture();

        string _reference = s.GetScriptureReference();
        string _verse = s.GetScriptureVerse();

        Console.WriteLine($"Reference:{_reference} Verse:{_verse}");
    }

    public void Clear()
    {
        Console.Clear();
    }
}