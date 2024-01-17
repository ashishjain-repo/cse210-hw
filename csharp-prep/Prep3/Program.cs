using System;
public class assignment_weektwo_one
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int magicNum = rnd.Next(101);
        Console.WriteLine(magicNum);
        bool loopVal = true;
        int counter = 0;
        while(loopVal)
        {
            Console.Write("What is your guess? ");
            string tempGuess = Console.ReadLine();
            int guessNum = int.Parse(tempGuess);
            counter++;
            if(guessNum == magicNum)
            {
                loopVal = false;
                Console.WriteLine("You Guessed It!");
                Console.WriteLine($"It took you {counter} guesses to get the write answer!");
            }
            else if(guessNum < magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }

    }
}