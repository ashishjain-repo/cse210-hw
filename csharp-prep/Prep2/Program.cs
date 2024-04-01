using System;

public class assignment_weekone_two
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the grade percentage for letter grade: ");
        string num = Console.ReadLine();
        float percentage = float.Parse(num);


        // if elif ladder:-
        if (percentage >= 97 && percentage <= 100)
        {
            Console.WriteLine("Your Letter Grade is 'A+'");
        }
        else if (percentage >= 93 && percentage <= 96)
        {
            Console.WriteLine("Your Letter Grade is 'A'");
        }
        else if (percentage >= 90 && percentage <= 92)
        {
            Console.WriteLine("Your Letter Grade is 'A-'");
        }
        else if (percentage >= 87 && percentage <= 89)
        {
            Console.WriteLine("Your Letter Grade is 'B+'");
        }
        else if (percentage >= 83 && percentage <= 86)
        {
            Console.WriteLine("Your Letter Grade is B");
        }
        else if (percentage >= 80 && percentage <= 82)
        {
            Console.WriteLine("Your Letter Grade is B-");
        }
        else if (percentage >= 77 && percentage <= 79)
        {
            Console.WriteLine("Your Letter Grade is C+");
        }
        else if (percentage >= 73 && percentage <= 76)
        {
            Console.WriteLine("Your Letter Grade is C");
        }
        else if (percentage >= 70 && percentage <= 72)
        {
            Console.WriteLine("Your Letter Grade is C-");
        }
        else if (percentage >= 67 && percentage <= 69)
        {
            Console.WriteLine("Your Letter Grade is D+");
        }
        else if (percentage >= 65 && percentage <= 66)
        {
            Console.WriteLine("Your Letter Grade is D");
        }
        else
        {
            Console.WriteLine("Your Letter Grade is F");
        }
    }
}