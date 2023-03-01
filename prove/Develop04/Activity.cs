using System;

public class Activity
{
    protected string _activityType;

    protected string _activityExplanation;

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

        d1.ClearConsole();

        Console.WriteLine($"Welcome to the {_activityType} Activity.\n\n{_activityExplanation}\n\nHow long, in seconds, would you like for your session?\n> ");
        
        int time = GetTime();

        d1.ClearConsole();

        DateTime currentTime = DateTime.Now;
        DateTime countdown = currentTime.AddSeconds(time);
        while (countdown > currentTime)
        {
            StartActivityLoop();
            currentTime = DateTime.Now;
        }
    }

    public virtual void StartActivityLoop()
    {

    }

    public int GetTime()
    {
        UserInteraction t1 = new Time();
        t1.SetUserInput();
        int time = t1.GetUserInput();
        return time;
    }
}