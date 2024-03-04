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

    public void CountDownTimer(int time, int times)
    {
        string[] spinnerSymbol = {"+","|","/","-","\\","|","/","-","\\","|"};
        for(int i = 0; i < times; i++)
        {

        foreach(string temp in spinnerSymbol)
        {
            Console.Write(temp);
            Thread.Sleep(time);
            Console.Write("\b \b");
        }
        }
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
    public void ReflectionResponse()
    {
        List<int> tempIndex = new List<int>();
        Random Rand = new Random();
        for(int i = 0; i < PromptsList.Count(); i++)
        {
            int tempNum = Rand.Next(0,PromptsList.Count());
            if(tempIndex.Contains(tempNum))
            {
                continue;
            }
            else
            {
                tempIndex.Add(tempNum);
            }

        }
        for(int i = 0; i < 1; i++)
        {
            Console.WriteLine($"> {PromptsList[tempIndex[0]]}");
            CountDownTimer(1000,2);
        }
    }
    public void ReflectionCompletion(int time)
    {
        Console.WriteLine("Well Done!!");
            Spinner();
            Console.WriteLine($"You have completed another {time} seconds of the {ActivityName}");
            Spinner();
    }
    public void ReflectionTimed(int time)
    {   
        // Console.WriteLine(time);
        bool inBool = true;
        int tempTime = 0;
        while(inBool)
        {
            tempTime+=15;
        if(tempTime <= time)
        {
            ReflectionResponse();
        }
        else
        {
            
            ReflectionCompletion(time);
            inBool= false;
        }
        }
    }
}
class ListingActivity : Activity
{
    public string[] Prompts = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public List<string> userResponse = new List<string>();
    public ListingActivity(string StartingMessage, string EndingMessage, string ActivityName, string Description, int Duration) : base(StartingMessage, EndingMessage, ActivityName, Description, Duration)
    {
        
    }
    public int ListingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{StartingMessage}\n\n{Description}\n");
        Console.Write("How Long, in seconds, would you like for you session? ");
        int activityDuration = Convert.ToInt32(Console.ReadLine());
        Duration = activityDuration;
        return activityDuration;
    }
    public void ListingPrompt()
    {
        Random Rand = new Random();
        int promptLength = Prompts.Count();
        int randomElement = Rand.Next(0,promptLength);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {Prompts[randomElement]} ---");
        Console.Write("You may begin in: ");
        NumberIteratorTimed(1);

    }
    /* public void ReflectionQuestions(int time)
    {
        
    } */
    public void ListingResponse(int time)
    {
        DateTime endTime = DateTime.Now.AddSeconds(time);
        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            userResponse.Add(userInput);
        }
        Console.WriteLine($"You listed {userResponse.Count()} items!");
        Console.WriteLine("Well Done !!");
        Spinner();
    }
    public void ListingCompletion(int time)
    {
        Console.WriteLine($"You have completed another {time} seconds of the Listing Activity");
    }
}