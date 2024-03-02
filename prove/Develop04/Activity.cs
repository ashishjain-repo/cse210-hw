using System;
using System.Timers;
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
        Console.WriteLine("Get ready...");
        foreach(string temp in spinnerSymbol)
        {
            Console.Write(temp);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

    }
public void SpinnerTimed(int time)
    {   
        string[] spinnerSymbol = {"+","|","/","-","\\","|","/","-","\\","|"};
        Console.WriteLine("Get ready...");
        foreach(string temp in spinnerSymbol)
        {
            Console.Write(temp);
            Thread.Sleep(time);
            Console.Write("\b \b");
        }

    }
    public void NumberIterator()
    {
        string[] iteratorSymbol = {"3","2","1","0"};
        foreach(string temp in iteratorSymbol)
        {
            Console.Write(temp);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Console.WriteLine("\n");
    }
    public void NumberIteratorTimed(int time)
    {
        string[] iteratorSymbol = {"3","2","1","0"};
        time = time * 1000;
        foreach(string temp in iteratorSymbol)
        {
            Console.Write(temp);
            Thread.Sleep(time);
            Console.Write("\b \b");
        }
        Console.WriteLine("\n");
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
        Duration = activityDuration;
        return activityDuration;
    }
    public void BreathingTimer(int duration)
    {
        if(duration%2 == 0)
        {
            for(int i = 0; i < (duration/4); i++)
            {
                Console.Write("Breathe In...."); NumberIterator();
                Console.Write("Breathe Out...."); NumberIterator();
                Console.WriteLine("\n");
            }
        }
        else
        {
            duration++;
            for(int i = 0; i < (duration/4); i++)
            {
                Console.Write("Breathe In...."); NumberIterator();
                Console.Write("Breathe Out...."); NumberIterator();
                Console.WriteLine("\n");
            }
        }
        BreathingCompletion(duration);
    }
    public void BreathingCompletion(int duration)
    {
        Console.WriteLine("Well Done!!");
        Spinner();
        Console.WriteLine($"You have completed another {duration} seconds of the {ActivityName}");
        Spinner();
    }
}
class ReflectionActivity : Activity
{
    public string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    public List<string> PromptsList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectionActivity(string StartingMessage, string EndingMessage, string ActivityName, string Description, int Duration) : base(StartingMessage, EndingMessage, ActivityName, Description, Duration)
    {
        
    }
    public int ReflectionMessage()
    {
        Console.Clear();
        Console.WriteLine($"{StartingMessage}\n\n{Description}\n");
        Console.Write("How Long, in seconds, would you like for you session? ");
        int activityDuration = Convert.ToInt32(Console.ReadLine());
        Duration = activityDuration;
        return activityDuration;
    }
    public void ReflectionPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Random Rand = new Random();
        int RandomNumber = Rand.Next(0,3);
        Console.WriteLine($"--- {Prompts[RandomNumber]} ---\n");
    }
    public void ReflectionQuestions()
    {
        Console.WriteLine("When you have something in mind, press Enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: "); NumberIteratorTimed(1);
    }
    public void ReflectionResponse(int time)
    {
        Random Rand = new Random();
        int listLength = PromptsList.Count();
        int[] tempListIndex = null;
        for(int i = 0; i<3; i++)
        {
            tempListIndex[i] = Rand.Next(0,listLength);
        }
        if(time % 2 == 0)
        {
            time*=1000;
        }
        else
        {
            time++;
            time*=1000;
        }
        bool insideBool = true;
        int counter = 0;
        while(insideBool)
        {
            if(counter == time)
            {
                insideBool = false;
            }
            foreach(var temp in tempListIndex)
            {
                Console.WriteLine(PromptsList[temp]);
            }
        }
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