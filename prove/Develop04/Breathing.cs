using System;

public class Breathing : Activity
{
    public override void InitializeValues()
    {
        SetActivityWord("Breathing");

        SetActivityExplanation("This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.");
    }

    public override void StartActivityLoop(int time)
    {  
        a.BreathingAnimation(4);
        
        Console.WriteLine();
    }
}