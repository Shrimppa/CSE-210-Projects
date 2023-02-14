using System;

class Program
{
    static void Main(string[] args)
    {
        ConsoleOutput consoleOut = new ConsoleOutput();
        int x = 1;

        consoleOut.Clear();
        consoleOut.GetData();
        consoleOut.Display();

        while (x != 0)
        {
            string press = Console.ReadLine();

            if (press == "quit")
            {
                x = 0;
            }
            else
            {
                consoleOut.Clear();
                bool quit = consoleOut.Display();
                if (quit == true)
                {
                    x = 0;
                }
            }
        }
    }
}