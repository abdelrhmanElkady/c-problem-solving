using System;
using System.Collections.Generic;

namespace problem_solving_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<string> lines = new List<string>();
            for (int i = 0; i < numberOfLines; i++)
            {
                lines.Add(Console.ReadLine());
            }

            foreach (var item in lines)
            {
                if (item.Length <= 10)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    //Console.WriteLine(item[0]+Convert.ToString(item.Length-2)+item[item.Length-1]);
                    Console.WriteLine($"{item[0]}{item.Length - 2}{item[item.Length - 1]}");
                }
            }
            
        }
    }
}

