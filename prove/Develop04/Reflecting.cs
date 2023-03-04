using System;

public class Reflecting : Activity
{
    public static List<string> _promptList = new List<string> 
    {
        "Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."
    };

    public static List<string> _secondaryPromptList = new List<string> 
    {
        "Why was this experience meaningful to you?","Have you ever done anything like this before?",
        "How did you get started?","How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public override void InitializeValues()
    {
        SetActivityWord("Reflecting");

        SetActivityExplanation("This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public override void StartActivityLoop(int time)
    {
        r = new Random();

        Console.WriteLine("Consider the following prompt:");
        
        int randomNumber = r.Next(_promptList.Count);
        int randomNumber2 = r.Next(_secondaryPromptList.Count);


        Console.WriteLine($"\n--- {_promptList[randomNumber]} ---");

        Thread.Sleep(4000);

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        
        Console.ReadLine();

        Console.WriteLine($"\nNow ponder on each of the following questions as they related to this experience.\n");

        Console.Write("You may begin in: ");

        Countdown();

        Console.Clear();

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
            Console.Write($"> {_secondaryPromptList[randomNumber2]} ");

            a = new Animation(7);

            a.DisplayResults();

            randomNumber2 = r.Next(_secondaryPromptList.Count);

            Console.Write("\n\n");
            currentTime = DateTime.Now;
        }
    }
}