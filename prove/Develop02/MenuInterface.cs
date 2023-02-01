using System;

public class MenuInterface
{
    public void Display()
    {
        Console.Write($"\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?\n> ");
    }
}