using System;

class Program
{
    static void Main(string[] args)
    {
        int[] values = Enumerable.Range(0, 10 - 0).ToArray();

        var valuesList = values.ToList();

        valuesList.RemoveAt(4);

        foreach (var item in valuesList)
        {
            Console.WriteLine($"{item}");
        }
        
        valuesList.Append(1);
        
        foreach (var item in valuesList)
        {
            Console.WriteLine($"{item}");
        }
    }
}