using System;

public class prep3
{
    public int createRandom()
    {
        Random rnd = new Random();
        int magicNum = rnd.Next(101);
        return magicNum;
    }

    static void Main(string[] args)
    {
        prep3 prep = new prep3();
        int magicNum = prep.createRandom();
        Console.WriteLine(magicNum);
        bool loopVal = true;
        int counter = 0;
        while (loopVal)
        {
            Console.Write("What is your guess? ");
            string tempGuess = Console.ReadLine();
            int guessNum = int.Parse(tempGuess);
            counter++;
            if (guessNum == magicNum)
            {
                Console.WriteLine("You Guessed It!");
                Console.WriteLine($"It took you {counter} guesses to get the write answer!");
                Console.WriteLine("Do you want to play again. [Y/N]");
                char question = char.Parse(Console.ReadLine());
                if (question == 'Y' || question == 'y')
                {
                    loopVal = true;
                    magicNum = prep.createRandom();
                    Console.WriteLine($"{magicNum}");
                }
                else
                {
                    loopVal = false;
                }
            }
            else if (guessNum < magicNum)
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