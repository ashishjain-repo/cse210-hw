using System;

class Program
{
    static void Main(string[] args)
    {
        int Points = 0;
        Goal goal1 = new Goal(Points);
        int menuChoice = goal1.ShowMenu();
        int goalType = goal1.NewGoal();
    }
}