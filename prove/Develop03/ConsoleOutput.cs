using System;

public class ConsoleOutput
{
    private string _verse;

    private string _reference;

    private int _num = 1;
        

    public void GetData()
    {
        Scripture s = new Scripture();

        s.GetScripture();

        string reference = s.GetScriptureReference();

        string verse = s.GetScriptureVerse();
     
        _reference = reference;

        _verse = verse;
    }

    public Word w = new Word();

    public bool Display()
    {
        Console.WriteLine($"\n{_reference}\n_____________________________________________________________________________________________________________________\n\n{_verse}\n");

        if (_num != 0)
        {
            w.GiveWords(_verse);
            _num = 0;
        }

        _verse = w.Hide();

        bool quit = w.FullyHidden();

        return quit;
    }

    public void Clear()
    {
        Console.Clear();
    }
}