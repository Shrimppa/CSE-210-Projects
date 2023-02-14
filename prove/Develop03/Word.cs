using System;

public class Word
{
    private string _originalWords;

    private string[] _words;

    private string[] _changedWords;

    public void GiveWords()
    {
        _words = "One Two Three Four Five Six".Split(" ");
        _originalWords = "One Two Three Four Five Six";
    }

    public void GiveWords(string words)
    {
        _words = words.Split(" ");
        _originalWords = words;
        _changedWords = _words;
    }

    public string Hide()
    {
        Random rand = new Random();

        string[] words = _changedWords;

        string[] ogWords = _words;

        int numOfWords = words.Count();

        int[] values = Enumerable.Range(0, numOfWords - 0).ToArray();

        var valuesList = values.ToList();

        var editedValuesList = valuesList;

        foreach (var item in valuesList)
        {
            if (words[item] != ogWords[item])
            {
                editedValuesList.RemoveAt(item);
            }
        }

        int x = 3;
        while (x != 0)
        {
            int randomNumber = rand.Next(editedValuesList.Count());

            // Debug Remove
            Console.WriteLine($"{editedValuesList[randomNumber]}");

            string word = words[editedValuesList[randomNumber]];

            int charCount = word.Length;

            string newWord = "";

            while (charCount != 0)
            {
                newWord = newWord + "_";

                charCount -= 1;
            }

            words[editedValuesList[randomNumber]] = newWord;

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