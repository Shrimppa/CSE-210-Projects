using System;

public class Scripture
{
    private string[,] _scriptureArray = 
    {
        {"Helaman 5:12","And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."},
        {"2 Nephi 9:28-29","O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God."},
        {"1 Nephi 3:7","And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."}
    };

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