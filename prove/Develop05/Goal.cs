using System.Dynamic;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Drawing;

class Goal
{
    protected int _points { get; set; }
    protected Dictionary<string, string> _goals = new Dictionary<string, string>();
    public Goal(int Points, Dictionary<string, string> Goals)
    {
        Points = _points;
        Goals = _goals;


    }
    public int ShowPoints(int Points,Dictionary<int, Dictionary<string, string>> Goals )
    {
        try
        {
            for (int i = 0; i < Goals.Count(); i++)
        {
            if(Goals[i]["Goal-Done"] == "X")
            {
                Points+= Convert.ToInt32(Goals[i]["Goal-Point"]);
                if(Goals[i].ContainsKey("Goal-Bonus"))
                {
                    Points += Convert.ToInt32(Goals[i]["Goal-Bonus"]) * Convert.ToInt32(Goals[i]["Goal-Bonus-Points"]);
                }
            }
        }
        }
        catch (System.Exception)
        {
        }
        return Points;
    }
    public void ShowPoints(int Points)
    {
        Console.WriteLine($"You have {Points} points.");
    }
    public int ShowMenu()
    {
        string[] menuOptions = { "1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Quit" };
        Console.WriteLine("Menu Options:");
        for (int i = 0; i < menuOptions.Count(); i++)
        {
            Console.WriteLine($"\t{menuOptions[i]}");
        }
        int Choice = Convert.ToInt32(Console.ReadLine());
        return Choice;
    }

    // Options Functions
    public int NewGoal()
    {
        string[] goalTypes = { "1. Simple Goals", "2. Eternal Goals", "3. Checklist Goals" };
        Console.WriteLine("The Types of goals are: ");
        for (int i = 0; i < goalTypes.Count(); i++)
        {
            Console.WriteLine($"\t{goalTypes[i]}");
        }
        int Choice = Convert.ToInt32(Console.ReadLine());

        return Choice;
    }
    public void GoalEntry(Dictionary<int, Dictionary<string, string>> Goals, Dictionary<string, string> TempGoals, int Count)
    {
        Goals.Add(Count, TempGoals);
    }

    public void ListGoals(Dictionary<int, Dictionary<string, string>> Goals, int Count)
    {
        Console.WriteLine("The goals are: ");
        int counter = 0;
        for (int i = 0; i < Count; i++)
        {
            counter++;
            string type = Goals[i]["Goal-Type"];
            string desc = Goals[i]["Goal-Desc"];
            string done = Goals[i]["Goal-Done"];
            if(Goals[i].ContainsKey("Goal-Bonus"))
            {
                string totalGoals = Goals[i]["Goal-Bonus"];
                string goalsDone = Goals[i]["Goal-Times-Done"];
                Console.WriteLine($"{counter}. [{done}] {type} ({desc})");
                Console.Write($"\t -- Currently Completed: {goalsDone}/{totalGoals}");
            }
            else
            {
                Console.WriteLine($"{counter}. [{done}] {type} ({desc})");
            }
        }
    }

    public void SaveGoals(Dictionary<int, Dictionary<string, string>> Goals)
    {
        Console.WriteLine("Enter the name of the file (Without Externsion: )");
        string fileName = Console.ReadLine();
        string filePath = $"{fileName}.json";
        string json = JsonSerializer.Serialize
        (
            Goals, new JsonSerializerOptions
            {
                WriteIndented = true
            }
        );
        File.WriteAllText(filePath, json);
        Console.WriteLine($"You succesfully saved the file named: {filePath}");
    }
    public (Dictionary<int, Dictionary<string, string>>, int) LoadGoals()
    {   
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string filePath = $"{filename}.json";
        string jsonString = File.ReadAllText(filePath);

        Dictionary<int, Dictionary<string, string>> localDict = JsonSerializer.Deserialize<Dictionary<int, Dictionary<string, string>>>(jsonString);
        int count = localDict.Count();
        return (localDict, count);
    }

    public int RecordEvent(Dictionary<int, Dictionary<string, string>> Goals, int Points)
    {
        int counter = 0;
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < Goals.Count(); i++)
        {
            counter++;
            Console.WriteLine($"{counter}. {Goals[i]["Goal-Type"]}");
        }
        Console.Write("Which Goal did you accomplish: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        int tempChoice = choice - 1;
        int innerPoints = 0;
        if(Goals.ContainsKey(tempChoice))
        {
            int tempPoints = Convert.ToInt32(Goals[tempChoice]["Goal-Point"]);
            innerPoints+=tempPoints;
            if(Goals[tempChoice].ContainsKey("Goal-Bonus"))
            {
                int tempBonus = Convert.ToInt32(Goals[tempChoice]["Goal-Bonus-Points"]);
                int tempBonusTimes = Convert.ToInt32(Goals[tempChoice]["Goal-Bonus"]);
                int tempGoalDone = Convert.ToInt32(Goals[tempChoice]["Goal-Times-Done"]);
                Goals[tempChoice]["Goal-Times-Done"] = Convert.ToString(tempGoalDone+1);
                if(Goals[tempChoice]["Goal-Times-Done"] == Goals[tempChoice]["Goal-Bonus"])
                {
                int BonusPoints = tempBonus * tempBonusTimes;
                innerPoints+=BonusPoints;
                Goals[tempChoice]["Goal-Done"] = "X";
                }
            }
            else
            {
                Goals[tempChoice]["Goal-Done"] = "X";
            }
    Console.WriteLine($"Congratulations! You have earned {innerPoints} points!");
        }
        else
        {
            Console.WriteLine("Incorrect option selected.");
        }
        int showPoints = Points + innerPoints;
        Console.WriteLine($"You now have {showPoints} points.");
        
        return innerPoints;

    }
    public virtual void GoalEntry(Dictionary<string, string> Goals)
    {

    }

}