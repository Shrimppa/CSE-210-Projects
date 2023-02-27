using System;

public class Choice : UserInteraction
{
    public string Choose()
    {  
        SetUserInput(Console.ReadLine());

        return GetUserInput();
    }
}