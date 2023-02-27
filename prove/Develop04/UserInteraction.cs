using System;

public class UserInteraction
{
    protected string _userInput;

    public virtual string GetUserInput()
    {
        return _userInput;
    }

    public void SetUserInput(string input)
    {
        _userInput = input;
    }
}