using System;


namespace problem_solving_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numOfParticipantsAndWinPosition = Console.ReadLine();
            string[] numOfParticipantsAndWinPositionArray = numOfParticipantsAndWinPosition.Split(" ");
            
            int winPosition = Convert.ToInt32(numOfParticipantsAndWinPositionArray[1]);

            string scores = Console.ReadLine();
            string[] scoresArray =  scores.Split(" ");
            int[] scoresArrayInt = new int[scoresArray.Length];

            int numberOfAdvancers = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
              scoresArrayInt[i] =  Convert.ToInt32(scoresArray[i]);
            }
            

            int scoreOfWinPosition = Convert.ToInt32(scoresArray[winPosition - 1]);

            for (int i = 0 ; i < scoresArray.Length; i++)
            {
                if(scoresArrayInt[i] > 0 && scoresArrayInt[i] >= scoreOfWinPosition)
                {
                    numberOfAdvancers++;
                }
            }

            Console.WriteLine(numberOfAdvancers);

        }
    }
}
