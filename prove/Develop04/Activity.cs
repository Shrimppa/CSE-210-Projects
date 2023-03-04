using System;

public class Activity
{
    protected string _activityType;

    protected string _activityExplanation;

    public Random r;

    public Animation a;

    public void SetActivityWord(string activityType)
    {
        _activityType = activityType;
    }

    public void SetActivityExplanation(string activityExplanation)
    {
        _activityExplanation = activityExplanation;
    }

    public void StartActivity()
    {
        Display d1 = new Display();

        a = new Animation(4);

        d1.ClearConsole();

        InitializeValues();

        Console.WriteLine($"Welcome to the {_activityType} Activity.\n\n{_activityExplanation}\n\nHow long, in seconds, would you like for your session?\n");
        
        int time = GetTime();

        d1.ClearConsole();

        Console.Write("Get ready...");

        a.DisplayResults();

        Console.WriteLine();

        DateTime currentTime = DateTime.Now;
        DateTime countdown = currentTime.AddSeconds(time);
        while (countdown > currentTime)
        {
            StartActivityLoop(time);
            currentTime = DateTime.Now;
        }
        Console.Write($"\n\nWell done!!");

        a.DisplayResults();

        Console.Write($"\n\nYou have completed {time} seconds of the {_activityType} Activity!");

        a.DisplayResults();
    }

    public virtual void StartActivityLoop(int time)
    {

    }

    public virtual void InitializeValues()
    {

    }

    public int GetTime()
    {
        UserInteraction t1 = new Time();
        t1.SetUserInput();
        int time = t1.GetUserInput();
        return time;
    }

    public void Countdown()
    {
        int x = 4;

        while (x != -1)
        {
            Console.Write(x);
            Thread.Sleep(1000);
            Console.Write($"\b \b");
            x -= 1;
        }
    }
}