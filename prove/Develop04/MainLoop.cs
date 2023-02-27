using System;

public class MainLoop
{
    public void StartProgram()
    {
        string choice = "0";

        Display menu = new Menu();

        Choice menuChoice = new Choice();

        Activity a1 = new Breathing();
        Activity a2 = new Reflecting();
        Activity a3 = new Listing();

        while (choice != "4")
        {
            menu.ClearConsole();
            menu.DisplayResults();

            choice = menuChoice.Choose();

            if (choice == "1")
            {
                a1.StartActivity();
            }
            else if (choice == "2")
            {
                a2.StartActivity();
            }
            else if (choice == "3")
            {
                a3.StartActivity();
            }
            else if (choice != "4")
            {
                menu.ClearConsole();
                Console.WriteLine("Please input '1', '2', '3', or '4'.");
                Thread.Sleep(3000);
            }
        }    
    }
}