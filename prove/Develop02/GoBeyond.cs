using System;

public class GoBeyond
{
    public static string GetInfo()
    {
        Console.Write($"\nWhat is your first name?\n> ");
        string first = Console.ReadLine();

        Console.Write($"\nWhat is your last name?\n> ");
        string last = Console.ReadLine();
        
        Console.Write($"\nWhat would you like the title of your journal to be?\n> ");
        string title = Console.ReadLine();

        string formattedPerson = $"\n{first} {last}'s Journal\n{title}";

        return formattedPerson;
    }
}