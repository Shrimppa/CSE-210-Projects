using System;

public class Word
{
    private string _originalWords;

    private string[] _words;

    private string[] _changedWords;

    private bool _fullyHidden = false;

    public bool FullyHidden()
    {
        return _fullyHidden;
    }

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
        var wordsList = words.ToList();
        wordsList.RemoveAll(str => String.IsNullOrEmpty(str));
        words = wordsList.ToArray();
        

        string[] ogWords = _words;
        var ogWordsList = ogWords.ToList();
        ogWordsList.RemoveAll(str => String.IsNullOrEmpty(str));
        ogWords = ogWordsList.ToArray();

        int numOfWords = words.Count();

        int[] values = Enumerable.Range(0, numOfWords - 0).ToArray();

        var valuesList = values.ToList();

        List<int> editedValuesList = new List<int> {};

        editedValuesList = valuesList.ToList();

        foreach (var item in valuesList)
        {
            if (words[item] != ogWords[item])
            {
                if (editedValuesList != null)
                {
                    editedValuesList.Remove(item);
                }
            }
        }

        int x = 3;

        if (editedValuesList.Count != 0)
        {
            if (editedValuesList.Count != 1 || editedValuesList.Count != 2 || editedValuesList.Count != 3)
            {
                while (x != 0 && editedValuesList.Count != 0)
                {
                    int randomNumber = rand.Next(editedValuesList.Count());

                    string word = words[editedValuesList[randomNumber]];

                    int charCount = word.Length;

                    string newWord = "";

                    while (charCount != 0)
                    {
                        newWord += "_";

                        charCount -= 1;

                        words[editedValuesList[randomNumber]] = newWord;

                        
                    }

                    editedValuesList.Remove(randomNumber);

                    x -= 1;
                    
                    _changedWords = words;
                }
            }
            else
            {
                foreach (var item in editedValuesList)
                {
                    string word = words[editedValuesList[item]];

                    int charCount = word.Length;

                    string newWord = "";

                    while (charCount != 0)
                    {
                        newWord += "_";

                        charCount -= 1;

                        words[editedValuesList[item]] = newWord;

                        
                    }

                    editedValuesList.Remove(item);

                    x -= 1;
                    
                    _changedWords = words;
                }
            }
        }
        else
        {
            _fullyHidden = true;
        }


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