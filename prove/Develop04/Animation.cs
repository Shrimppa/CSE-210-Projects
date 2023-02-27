using System;

public class Animation : Display
{
    public Time time;
    public override void DisplayResults()
    {
        time = new Time();

        //

        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);        
    }
}