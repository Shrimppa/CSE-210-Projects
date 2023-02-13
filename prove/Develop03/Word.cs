using System;

public class Word
{
    private string _originalWords;

    private string[] _words;

    private string[] _changedWords;

    public Word()
    {
        _words = "One Two Three Four Five Six".Split(" ");
        _originalWords = "One Two Three Four Five Six";
    }

    public Word(string words)
    {
        _words = words.Split(" ");
        _originalWords = words;
        _changedWords = _words;
    }

    public string Hide()
    {
        string[] words = _changedWords;

        string[] ogWords = _words;

        Random rand = new Random();

        int y = 1;

        foreach (string item in ogWords)
        {
            if (words[y] != item)
            {
                
            }
            y += 1;
        }


        int x = 3;
        while (x != 0)
        {
            int randomNumber = rand.Next(words.Count());

            if (words[randomNumber] == ogWords[randomNumber])
            {
                string word = words[randomNumber];

                int charCount = words.Length;

                string newWord = "";

                while (charCount != 0)
                {
                    newWord = newWord + "_";

                    charCount -= 1;
                }

                words[randomNumber] = newWord;
            }
            else
            {
                
            }


            x -= 1;
            
        }

        _changedWords = words;

        string formattedString = "";

        foreach (string element in words)
        {
            formattedString = formattedString + element + " ";
        }

        return formattedString;
    }

    public string Show()
    {
        return _originalWords;
    }
}   