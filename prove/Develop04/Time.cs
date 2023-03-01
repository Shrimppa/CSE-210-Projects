using System;

public class Time : UserInteraction
{
    public override void SetUserInput()
    {
        int input = int.Parse(Console.ReadLine());
        _userInput = input;
    }
}