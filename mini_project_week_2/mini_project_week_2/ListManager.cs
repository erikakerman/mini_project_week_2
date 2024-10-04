using System;
using System.Collections.Generic;

public class ListManager
{
    private List<string> itemList;

    public ListManager()
    {
        itemList = new List<string>();
    }

    public void AddItem(string item)
    {
        itemList.Add(item);
        Console.WriteLine("'{item}' added. List now has {itemList.Count} items.");
    }

    public void DisplayList()
    {
        Console.WriteLine("\nFinal list:");
        foreach (string item in itemList)
        {
            Console.WriteLine(item);
        }
    }
}