using System;

public class Animation : Display
{
    public Time time;

    private int _loopAmount;
    
    public Animation()
    {
        _loopAmount = 1;
    }

    public Animation(int numberOfLoops)
    {
        _loopAmount = numberOfLoops;
    }
    public override void DisplayResults()
    {
        time = new Time();

        int loops = _loopAmount;

        Console.Write("   ");

        while (loops != 0)
        {
            Console.Write("∙∙∙∙∙∙∙");
            Thread.Sleep(125);     
            Console.Write($"\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("L∙∙∙∙∙∙");
            Thread.Sleep(125);     
            Console.Write($"\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");  
            Console.Write("Lo∙∙∙∙∙");
            Thread.Sleep(125);       
            Console.Write($"\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");  
            Console.Write("Loa∙∙∙∙");
            Thread.Sleep(125);       
            Console.Write($"\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");  
            Console.Write("Load∙∙∙");
            Thread.Sleep(125);       
            Console.Write($"\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");  
            Console.Write("Loadi∙∙");
            Thread.Sleep(125);       
            Console.Write($"\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");  
            Console.Write("Loadin∙");
            Thread.Sleep(125);       
            Console.Write($"\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");  
            Console.Write("Loading");
            Thread.Sleep(125);       
            Console.Write($"\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");  



            loops -= 1; 
        }
    }

    public void BreathingAnimation(int seconds)
    {
        Console.WriteLine();

        seconds = seconds * 1000;
        Console.Write("∙∙∙∙∙∙ ∙∙");
        Thread.Sleep(seconds/8); 
        Console.Write($"\b\b\b\b\b\b\b\b\b         \b\b\b\b\b\b\b\b\b");  
        Console.Write("B∙∙∙∙∙ ∙∙");
        Thread.Sleep(seconds/8); 
        Console.Write($"\b\b\b\b\b\b\b\b\b         \b\b\b\b\b\b\b\b\b");  
        Console.Write("Br∙∙∙∙ ∙∙");
        Thread.Sleep(seconds/8); 
        Console.Write($"\b\b\b\b\b\b\b\b\b         \b\b\b\b\b\b\b\b\b");  
        Console.Write("Bre∙∙∙ ∙∙");
        Thread.Sleep(seconds/8); 
        Console.Write($"\b\b\b\b\b\b\b\b\b         \b\b\b\b\b\b\b\b\b");  
        Console.Write("Brea∙∙ ∙∙");
        Thread.Sleep(seconds/8); 
        Console.Write($"\b\b\b\b\b\b\b\b\b         \b\b\b\b\b\b\b\b\b");  
        Console.Write("Breat∙ ∙∙");
        Thread.Sleep(seconds/8); 
        Console.Write($"\b\b\b\b\b\b\b\b\b         \b\b\b\b\b\b\b\b\b");  
        Console.Write("Breath ∙∙");
        Thread.Sleep(seconds/8); 
        Console.Write($"\b\b\b\b\b\b\b\b\b         \b\b\b\b\b\b\b\b\b");  
        Console.Write("Breath i∙");
        Thread.Sleep(seconds/8); 
        Console.Write($"\b\b\b\b\b\b\b\b\b         \b\b\b\b\b\b\b\b\b");  
        Console.Write("Breath in");

        Console.WriteLine();

        Console.Write("∙∙∙∙∙∙ ∙∙∙");
        Thread.Sleep(seconds/9); 
        Console.Write($"\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b");  
        Console.Write("B∙∙∙∙∙ ∙∙∙");
        Thread.Sleep(seconds/9); 
        Console.Write($"\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b");  
        Console.Write("Br∙∙∙∙ ∙∙∙");
        Thread.Sleep(seconds/9); 
        Console.Write($"\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b");  
        Console.Write("Bre∙∙∙ ∙∙∙");
        Thread.Sleep(seconds/9); 
        Console.Write($"\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b");  
        Console.Write("Brea∙∙ ∙∙∙");
        Thread.Sleep(seconds/9); 
        Console.Write($"\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b");  
        Console.Write("Breat∙ ∙∙∙");
        Thread.Sleep(seconds/9); 
        Console.Write($"\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b");  
        Console.Write("Breath ∙∙∙");
        Thread.Sleep(seconds/9); 
        Console.Write($"\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b");  
        Console.Write("Breath o∙∙");
        Thread.Sleep(seconds/9); 
        Console.Write($"\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b");  
        Console.Write("Breath ou∙");
        Thread.Sleep(seconds/9); 
        Console.Write($"\b\b\b\b\b\b\b\b\b\b          \b\b\b\b\b\b\b\b\b\b");  
        Console.Write("Breath out");
    }
}