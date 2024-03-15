using System.Dynamic;
using System.Collections.Generic;
class Goal
{
    protected int _points {get; set;}
    protected Dictionary<string,string> _goals = new Dictionary<string, string>();
    public Goal(int Points, Dictionary<string,string> Goals)
    {
        Points = _points;
        Goals = _goals;
        
        
    }
    public int ShowMenu()
    {
        string[] menuOptions = {"1. Create New Goal","2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Quit"};
        Console.WriteLine("Menu Options:");
        for(int i = 0; i < menuOptions.Count(); i++)
        {
            Console.WriteLine($"\t{menuOptions[i]}");
        }
        int Choice = Convert.ToInt32(Console.ReadLine());
        return Choice;
    }

    // Options Functions
    public int NewGoal()
    {
        string[] goalTypes = {"1. Simple Goals", "2. Eternal Goals","3. Checklist Goals"};
        Console.WriteLine("The Types of goals are: ");
        for(int i = 0; i < goalTypes.Count(); i++)
        {
            Console.WriteLine($"\t{goalTypes[i]}");
        }
        int Choice = Convert.ToInt32(Console.ReadLine());

        return Choice;
    }

    public void ListGoals(Dictionary<int, Dictionary<string,string>> Goals, int Count)
    {
        Console.WriteLine("The goals are: ");
        int counter = 0;
        for(int i = 0; i < Count; i++)
        {
            counter++;
            string type = Goals[i]["Goal-Type"];
            string desc = Goals[i]["Goal-Desc"];
            string done = Goals[i]["Goal-Done"];
            Console.WriteLine($"{counter}. [{done}] {type} ({desc})");
        }
    }

    public void ShowPoints(int Points)
    {
        Console.WriteLine($"You have {Points} points.");
    }
    public virtual void GoalEntry(Dictionary<string,string> Goals)
    {

    }
    public void GoalEntry(Dictionary<int,Dictionary <string,string>> Goals, Dictionary<string,string> TempGoals, int Count)
    {
        Goals.Add(Count, TempGoals);
    }
}