using System;

class Program
{
    static void Main(string[] args)
    {
        bool MainLoop = true;
        while (MainLoop)
        {
            List<string> Goals = new List<string>();
            int Points = 0;
            Goal goal1 = new Goal(Points, Goals);
            int MenuChoice = goal1.ShowMenu();
            switch (MenuChoice)
            {
                case 1:
                    int GoalType = goal1.NewGoal();
                    bool GoalTypeBool = true;
                    while (GoalTypeBool)
                    {
                        if (GoalType == 1)
                        {
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