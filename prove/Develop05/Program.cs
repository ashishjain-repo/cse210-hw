using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,Dictionary<string, string>> Goals = new Dictionary<int, Dictionary<string, string>>();
        int Count = 0;
        int Points = 0;
        bool MainLoop = true;
        while (MainLoop)
        {
            Dictionary<string, string> TempGoals = new Dictionary<string, string>();
            Goal goal = new Goal(Points, TempGoals);
            goal.ShowPoints(Points);
            int MenuChoice = goal.ShowMenu();
            switch (MenuChoice)
            {
                case 1:
                    int GoalType = goal.NewGoal();
                    bool GoalTypeBool = true;
                    while (GoalTypeBool)
                    {
                        if (GoalType == 1)
                        {
                            Simple simpleGoal = new Simple(Points, TempGoals);
                            simpleGoal.GoalEntry(TempGoals);
                            goal.GoalEntry(Goals, TempGoals, Count);
                            Count++;
                            GoalTypeBool = false;
                        }
                        else if (GoalType == 2)
                        {
                            GoalTypeBool = false;
                        }
                        else if (GoalType == 3)
                        {
                            GoalTypeBool = false;
                        }
                        else
                        {
                            Console.WriteLine("Please Choose From The Given Options");
                            GoalTypeBool = true;
                        }
                    }
                    break;
                case 2:
                goal.ListGoals(Goals,Count);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    MainLoop = false;
                    break;
                default:
                    break;
            }


        }

    }
}