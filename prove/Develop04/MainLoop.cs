using System;

public class MainLoop
{
    private static List<Activity> _activityList = new List<Activity>{};

    public void StartProgram()
    {
        int choice = 0;

        Display menu = new Menu();

        UserInteraction menuChoice = new UserInteraction();

        Activity a1 = new Breathing();
        Activity a2 = new Reflecting();
        Activity a3 = new Listing();

        _activityList.Add(a1);
        _activityList.Add(a2);
        _activityList.Add(a3);

       List<Activity> activityList = _activityList;

        while (choice != 4)
        {
            menu.ClearConsole();
            menu.DisplayResults();

            menuChoice.SetUserInput();
            string choice1 = menuChoice.GetUserInput();
            choice = int.Parse(choice1);

            activityList[choice].StartActivity();

            if (choice != 4)
            {
                menu.ClearConsole();
                Console.WriteLine("Please input '1', '2', '3', or '4'.");
                Thread.Sleep(3000);
            }
        }    

        if (choice == 4)
        {
            Console.Clear();
            Console.WriteLine("Wait no don't go ;-; I love doing these activities with you!");
            Thread.Sleep(2500);
            Console.Clear();
        }
    }
}