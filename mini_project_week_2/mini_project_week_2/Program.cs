using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> itemList = new List<string>();

        Console.WriteLine("Enter items to add to your list. Type 'exit' to finish.");

        while (true)
        {
            Console.Write("Enter an item: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            itemList.Add(input);
            Console.WriteLine($"'{input}' added. List now has {itemList.Count} item(s).");
        }

        Console.WriteLine("\nFinal list:");
        foreach (string item in itemList)
        {
            Console.WriteLine(item);
        }
    }
}