class Activity
{
    public string StartingMessage {get; set;}
    public string EndingMessage {get; set;}
    public string ActivityName {get; set;}
    public string Description {get; set;}
    public int Duration {get; set;}
    
    public Activity()
    {

    }
    public Activity(string smessage, string emessage, string aname, string description, int duration)
    {
        StartingMessage = smessage;
        EndingMessage = emessage;
        ActivityName = aname;
        Description = description;
        Duration = duration;
    }
    public void Spinner()
    {
        string[] spinnerSymbol = {"+","|","/","-","\\","|","/","-","\\","|"};
        foreach(string temp in spinnerSymbol)
        {
            Console.Write(temp);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }

    }

    public void CountDownTimer()
    {

    }
}
class BreathingActivity : Activity
{   
    public List<string> Prompts = new List<string>();
    public BreathingActivity(string StartingMessage, string EndingMessage, string ActivityName, string Description, int Duration) : base(StartingMessage, EndingMessage, ActivityName, Description, Duration)
    {
        
    }
    public int BreathingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{StartingMessage}\n\n{Description}\n");
        Console.Write("How Long, in seconds, would you like for you session? ");
        int activityDuration = Convert.ToInt32(Console.ReadLine());
        return activityDuration;
    }
    public void BreathingTimer()
    {

    }
    public void BreathingCompletion()
    {

    }
}
class ReflectionActivity : Activity
{
    public List<string> Prompts = new List<string>();
    public ReflectionActivity(string StartingMessage, string EndingMessage, string ActivityName, string Description, int Duration) : base(StartingMessage, EndingMessage, ActivityName, Description, Duration)
    {
        
    }
    public void ReflectionMessage()
    {

    }
    public void ReflectionPrompt()
    {

    }
    public void ReflectionQuestions()
    {

    }
    public void ReflectionResponse()
    {

    }
    public void ReflectionCompletion()
    {

    }
}
class ListingActivity : Activity
{
    public List<string> Prompts = new List<string>();
    public ListingActivity(string StartingMessage, string EndingMessage, string ActivityName, string Description, int Duration) : base(StartingMessage, EndingMessage, ActivityName, Description, Duration)
    {
        
    }
    public void ListingMessage()
    {

    }
    public void ReflectionPrompt()
    {

    }
    public void ReflectionQuestions()
    {

    }
    public void ReflectionResponse()
    {

    }
    public void ReflectionCompletion()
    {

    }
}