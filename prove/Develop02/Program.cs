using System;

class Program
{

    static void Main(string[] args)
    {
        MenuInterface menu = new MenuInterface();
        PromptGenerator prompt = new PromptGenerator();
        JournalManager journal = new JournalManager();


        menu.Display();
        string userInput = Console.ReadLine();
        int x = 1;
        string entry = "";
        string[] loadedFile;
        loadedFile = new string[1] {""}; 
        journal._entriesList.Add("");
        List<string> pList = new List<string>();
        pList = PromptGenerator._promptList;
        int randomNum = 0;

        while (x != 0)
        {
            if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5" || userInput == "reset")
            {
                if (userInput == "1")
                {
                    //Write
                    randomNum = prompt.Display();

                    entry = Console.ReadLine();

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    string prompt1 = pList[randomNum];

                    string formattedEntry = $"Date: {dateText} - Prompt: {prompt1} \n> {entry}";

                    journal._entriesList.Add(formattedEntry);

                    userInput = "reset";
                }
                else if (userInput == "2")
                {
                    //Display
                    journal.Display();


                    userInput = "reset";
                }
                else if (userInput == "3")
                {
                    //Load
                    loadedFile = journal.Load();
                    journal._loadedFile = loadedFile;

                    userInput = "reset";
                }
                else if (userInput == "4")
                {
                    //Save
                    journal.Save();

                    userInput = "reset";

                }
                else if (userInput == "5")
                {
                    //Quit
                    x = 0;

                    userInput = "reset";
                }
                else if (userInput == "reset")
                {
                    menu.Display();
                    userInput = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Error, you have to input either a 1, 2, 3, 4, or 5.\n> ");
                userInput = Console.ReadLine();
            }
        }
    }
}