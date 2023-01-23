using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int number = 1;
        int sum = 0;
        int increment = 0;
        int largestNumber = 0;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            sum = sum + number;
            increment = increment + 1;
            numbers.Add(number); // You can do whatever you want with this list of numbers although I did all previous calculations without a list
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        float average = 0;
        average = sum / increment;
        Console.WriteLine($"The sum is: {sum}\nThe average is: {average}\nThe largest number is: {largestNumber}");
    }
}