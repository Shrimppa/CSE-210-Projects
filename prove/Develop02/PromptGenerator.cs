using System;

public class PromptGenerator
{
    public static List<string> _promptList = new List<string> 
    {
        "What are your plans for this weekend?","What is one important life lesson you have learned?",
        "What is the last dream you remember?","What are your biggest fears?",
        "What would you do if you were granted three wishes?","What was the last show you went to?",
        "When were you last surprised?","What 5 things are you grateful for this week?","Did you make healthy choices today?",
        "What is your 1-year goal?","Who is someone that inspires you and why?",
        "What kind of person do you aspire to be?","Where is the place you would like to visit the most?",
        "If you could go back in time, where would you go?","How are you feeling today?",
        "What do you feel happy about right now?","If you could describe your day in one word, what would it be?",
        "How can you make tomorrow a better day than today?","Write down anything causing you stress right now.",
        "What outstanding tasks do you have?","If money was not a factor, what would you do today?",
        "What would you do if you could not fail?","If you could meet any fictional character, who would it be?",
        "If you had 3 wishes, what would you ask for?","If you could invent a new holiday, what would it be?","What is something you need to get off your chest?"
    };

    public int Display()
    {
        Random random = new Random();
        int randomNumber = random.Next(_promptList.Count);
        Console.WriteLine($"{_promptList[randomNumber]}");
        Console.Write("> ");
        return randomNumber;
    }
}