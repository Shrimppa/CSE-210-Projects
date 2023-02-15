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

        string verse = s.GetScriptureVerse();
     
        _reference = reference;

        _verse = verse;

        w = new Words(_verse);
    }

    public Words w;

    public void Display()
    {
        Clear();
        GetData();

        bool quit = false;

        Console.Write($"\n{_reference}\n_____________________________________________________________________________________________________________________\n\n{_verse}\n\nPress Enter to Continue or type 'quit' to finish: ");
        Console.ReadLine();

        string press = "";

        while (quit != true)
        {
            Clear();
            _verse = w.Hide(3);
            Console.Write($"\n{_reference}\n_____________________________________________________________________________________________________________________\n\n{_verse}\n\nPress Enter to Continue or type 'quit' to finish: ");
            quit = w.FullyHidden();
            
            if (quit != true)
            {
                press = Console.ReadLine();
            }

            if (press == "quit")
            {
                quit = true;
            }
        }

    }

    public void Clear()
    {
        Console.Clear();
    }
}