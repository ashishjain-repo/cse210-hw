class Checklist : Goal
{
    public Checklist (int Points, Dictionary<string,string> Goals) : base(Points, Goals)
    {
        Points = _points;
        Goals = _goals;
    }

    public override void GoalEntry(Dictionary<string,string> Goals)
    {
        Console.WriteLine("What is the name of your goal? ");
        string GoalType = Console.ReadLine();
        Goals["Goal-Type"] = GoalType;
        
        Console.WriteLine("What is a short description of it? ");
        string GoalDesc = Console.ReadLine();
        Goals["Goal-Desc"] = GoalDesc;
        
        Console.WriteLine("What is the number of points associated with this goal? ");
        string GoalPoint = Console.ReadLine();
        Goals["Goal-Point"] = GoalPoint;

        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        string GoalBonus = Console.ReadLine();
        Goals["Goal-Bonus"] = GoalBonus;

        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        string GoalBonusPoints = Console.ReadLine();
        Goals["Goal-Bonus-Points"] = GoalBonusPoints;

        Goals["Goal-Times-Done"] = "0";
        // Goal Done is to check whether it is true or false, if true should be reaplaced with 'X'
        Goals["Goal-Done"] = " ";
        // This is for the type of quest to make other functions easy to read.
        Goals["Goal-Quest"] = "Checklist";
    }
}