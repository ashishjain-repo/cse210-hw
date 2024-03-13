using System;

class Program
{
    static void Main(string[] args)
    {
        int Points = 0;
        List<string> Goals = new List<string>();
        Goal goal1 = new Goal(Points,Goals);
        int menuChoice = goal1.ShowMenu();
        int goalType = goal1.NewGoal();
    }
}