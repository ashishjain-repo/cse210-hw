using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool whileLoop = true;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (whileLoop)
        {
            Console.Write("Enter Number: ");
            string tempNumber = Console.ReadLine();
            int tempInteger = int.Parse(tempNumber);
            if (tempInteger == 0)
            {
                whileLoop = false;
                int listSize = numbers.Count;
                int listSum = 0;
                float listAverage = 0F;
                int listLargest = numbers[0];
                int listSmallest = numbers[0];
                for(int i = 0; i < listSize; i++)
                {
                    listSum += numbers[i];
                    if(numbers[i] > listLargest)
                    {
                        listLargest = numbers[i];
                    }
                    else if(numbers[i] < listSmallest)
                    {
                        listSmallest = numbers[i];
                    }
                }
                float tempListSum = listSum;
                float tempListSize = listSize;
                listAverage = tempListSum / tempListSize;
                Console.WriteLine($"The sum is: {listSum}");
                Console.WriteLine($"The average is: {listAverage}");
                Console.WriteLine($"The Largest Number is: {listLargest}");
                Console.WriteLine($"The Smallest Number is: {listSmallest}");

            }
            else
            {
                numbers.Add(tempInteger);
            }
        }
    }
}