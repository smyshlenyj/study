using System;
using System.Collections.Generic;
using System.Linq;

public class Num 
{
    public static void Main()
    {
         string fall = Console.ReadLine();
         List<string> list = fall.Split(' ').ToList();
                    foreach (string word in list)
           {
           Console.WriteLine(word + " ");
           }
         for (int i = 0; i <= list.Count; i++)
         {
            Console.WriteLine(list[i].Contains('1') + " " + list[i]);
             if (list[i].ToString().Contains('1')) list.RemoveAt(i);
         }
         
         
           foreach (string word in list)
           {
           Console.WriteLine(word + " ");
           }
    }
}
