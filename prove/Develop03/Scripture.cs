using System;

public class Scripture
{
    private string[,] _scriptureArray = {{"Ref 1","Verse Hello Mine now how"},{"Ref 2","Very cool man wow bow"},{"Ref 3","Version hello pie jello mine"}};

    private string[] _randomScripture;

    public void GetScripture()
    {
        Random random = new Random();
        int randomNumber = random.Next(_scriptureArray.GetLength(0));
        string _scriptureReference = _scriptureArray[randomNumber,0];
        string _scriptureVerse = _scriptureArray[randomNumber, 1];
        string[] _scripture = new string[]{_scriptureReference, _scriptureVerse};

        _randomScripture = _scripture;
    }

    public string GetScriptureReference()
    {
        string _scriptureReference = _randomScripture[0];

        return _scriptureReference;
    }

    public string GetScriptureVerse()
    {
        string _scriptureVerse = _randomScripture[1];

        return _scriptureVerse;
    }
}