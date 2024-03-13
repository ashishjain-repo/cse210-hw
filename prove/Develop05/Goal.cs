class Goal
{
    protected int _points = 0;
    protected string[] menuOptions = {"1. Create New Goal","2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Quit"};
    protected string[] goalTypes = {"1. Simple Goals", "2. Eternal Goals","3. Checklist Goals"};

        
    public Goal(int Points)
    {
        Points = _points;
    }
    public int ShowMenu()
    {
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
        
        Console.WriteLine("The Types of goals are: ");
        for(int i = 0; i < goalTypes.Count(); i++)
        {
            Console.WriteLine($"\t{goalTypes[i]}");
        }
        int Choice = Convert.ToInt32(Console.ReadLine());

        return Choice;
    }
}