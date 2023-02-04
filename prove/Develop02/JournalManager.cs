using System;

public class JournalManager
{   
    public string[] _loadedFile;

    public List<string> _entriesList = new List<string>();

    public void Save()
    {
        string personalInfo = GoBeyond.GetInfo();

        Console.Write($"\nWhat is the file name?\n> ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{personalInfo}");

            if (_loadedFile != null)
            {
                foreach (string item in _loadedFile)
                {
                    outputFile.WriteLine($"{item}");
                }
            }
            foreach (string item in _entriesList)
            {
                outputFile.WriteLine($"{item}");
            }
        }
    }

    public string[] Load()
    {
        Console.Write($"\nWhat is the file name?\n> ");

        string filename = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        return lines;
    }

    public void Display()
    {
        if (_loadedFile != null)
        {
            foreach (string line in _loadedFile)
            {
                Console.WriteLine($"{line}");
            }
        }

        if (_entriesList != null)
        {
            foreach (string line in _entriesList)
            {
                Console.WriteLine($"{line}");
            }
        }
    }
}