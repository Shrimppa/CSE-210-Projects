using System;

public class UserInteraction
{
    protected dynamic _userInput;

    public dynamic GetUserInput()
    {
        return _userInput;
    }

    public virtual void SetUserInput()
    {
        string input = Console.ReadLine();
        _userInput = input;
    }

    public virtual void SetUserInput(string input)
    {
        _userInput = input;
    }
}