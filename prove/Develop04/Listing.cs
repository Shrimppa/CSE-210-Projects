using System;

public class Listing : Activity
{
    public static List<string> _promptList = new List<string> 
    {
        "Who are people that you appreciate?","What are personal strengths of yours?",
        "Who are people that you have helped this week?","When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void InitializeValues()
    {
        SetActivityWord("Listing");

        SetActivityExplanation("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public override void StartActivityLoop(int time)
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");

        r = new Random();
        
        int randomNumber = r.Next(_promptList.Count);

        Console.WriteLine($"\n--- {_promptList[randomNumber]} ---\n");

        Console.Write("You may begin in:");

        Countdown();

        Console.WriteLine();

        int editedTime;

        if (time > 10)
        {
            editedTime = time - 2;
        }
        else
        {
            editedTime = 8; 
        }

        DateTime currentTime = DateTime.Now;
        DateTime countdown = currentTime.AddSeconds(editedTime);
        while (countdown > currentTime)
        {
            Console.Write("\n> ");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
}