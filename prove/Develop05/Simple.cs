class Simple : Goal
{
    public Simple (int Points, Dictionary<string,string> Goals) : base(Points, Goals)
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
        // Goal Done is to check whether it is true or false, if true should be reaplaced with 'X'
        Goals["Goal-Done"] = " ";
        // This is for the type of quest to make other functions easy to read.
        Goals["Goal-Quest"] = "Simple";
    }
}