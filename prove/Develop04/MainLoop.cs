using System;

public class MainLoop
{
    public void StartProgram()
    {
        string choice = "0";

        Display menu = new Menu();

        UserInteraction menuChoice = new UserInteraction();

        Activity a1 = new Breathing();
        Activity a2 = new Reflecting();
        Activity a3 = new Listing();

        while (choice != "4")
        {
            menu.ClearConsole();
            menu.DisplayResults();

            menuChoice.SetUserInput();
            choice = menuChoice.GetUserInput();

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

        if (choice == "4")
        {
            Console.Clear();
            Console.WriteLine("Wait no don't go ;-; I love doing these activities with you!");
            Thread.Sleep(2500);
            Console.Clear();
        }
    }
}