using System;

public class Menu : Display
{
    public override void DisplayResults()
    {
        Console.Write($"Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ");
    }
}