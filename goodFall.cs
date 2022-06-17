using System;
using System.Collections.Generic;
using System.Linq;

public class Num
{
    public static void Main()
    {
        string fall = Console.ReadLine();
        List<string> list = fall.Split(' ').ToList();
        Console.WriteLine("Список, полученный из консоли:");
        Console.WriteLine("-----------------------------");
        foreach (string word in list)
        {
            Console.WriteLine(word + " ");
        }
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Проверяем как ведет себя Contains(\"1\"):");
        Console.WriteLine("-----------------------------");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i].Contains("1") + " " + list[i]);
        }
        Console.WriteLine("-----------------------------");

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].ToString().Contains("1"))
            {
                list.RemoveAt(i);
                i--;
            }
        }
        foreach (string word in list)
        {
            Console.WriteLine(word + " ");
        }
    }
}
