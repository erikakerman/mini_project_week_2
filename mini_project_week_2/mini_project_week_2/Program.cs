using System;

class Program
{
    static void Main()
    {
        ListManager manager = new ListManager();

        Console.WriteLine("Enter items to add to your list. Type 'exit' to finish.");

        while (true)
        {
            Console.Write("Enter an item: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            manager.AddItem(input);
        }

        manager.DisplayList();
    }
}