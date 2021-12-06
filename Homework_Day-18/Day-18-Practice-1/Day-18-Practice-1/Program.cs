using System;

namespace Day_18_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedItem<int> linkedItem = new LinkedItem<int>();
            linkedItem.AddItem(1);
            linkedItem.AddItem(3);
            linkedItem.AddItem(24);
            linkedItem.AddItem(22344);
            linkedItem.AddItem(2400);
            Console.WriteLine("Current data:");
            linkedItem.PrintItems();
            Console.WriteLine("Enter index to return data[number] ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(linkedItem[index]);
            Console.WriteLine("Now add item to the end of list: ");
            int data = int.Parse(Console.ReadLine());
            linkedItem[index]= data;
            linkedItem.PrintItems();


        }
    }
}
