using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeNumeric = int.Parse(grade);
        string mark = "";
        int lastDigit = gradeNumeric % (10);
        int firstDigit = gradeNumeric;
        
        while (firstDigit >= 10)
        {
            firstDigit /= 10;
        }

        string sign = "";

        if (firstDigit != 9)
        {
            if (firstDigit > 5)
            {
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
        }
        if (gradeNumeric >= 90)
        {
            mark = "A";
        }
        else if (gradeNumeric >= 80)
        {
            mark = "B";
        }
        else if (gradeNumeric >= 70)
        {
            mark = "C";
        }
        else if (gradeNumeric >= 60)
        {
            mark = "D";
        }
        else
        {
            mark = "F";
        }

        string pass = "";

        if (gradeNumeric >= 70)
        {
            pass = "You passed the class! Congratulations on this ahceivement.";
        }
        else
        {
            pass = "You failed the class. Try retaking it, and i'm sure you can make it next time!";
        }

        Console.WriteLine($"Your grade is a {mark}{sign}. {pass}");
    }
}