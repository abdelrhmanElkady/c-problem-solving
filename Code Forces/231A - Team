using System;
using System.Collections.Generic;

namespace problem_solving_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfProblems = Convert.ToInt32(Console.ReadLine());
            int solvedProblems = 0 ;
            
            for (int i = 0; i < numberOfProblems; i++)
            {
                string[] listOfVotes;
                
               string line = Console.ReadLine();
                listOfVotes =  line.Split(' ');
                int sum = 0;
                foreach (var item in listOfVotes)
                {
                    
                    sum+=Convert.ToInt32(item);
                }
                if (sum >= 2)
                {
                    solvedProblems++;
                }
            }

            Console.WriteLine(solvedProblems);
        }
    }
}
