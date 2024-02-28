using System;

class Program
{
    static void Main(string[] args)
    {
        int Duration;
        string ActivityName;
        string StartingMessage;
        string EndingMessage;
        string Description;
        
        bool mainLoop = true;
        while(mainLoop)
        {
            Activity activity = new Activity();
            // activity.Spinner();

            Console.WriteLine("Menu Options:");
            string[] menuOptions = {"1. Start Breathing Activity",
            "2. Start Reflecting Activity",
            "3. Start Listing Activity",
            "4. Quit"};
            int choiceOption;
            foreach(string option in menuOptions)
            {
                Console.WriteLine($"  {option}");
            }
            choiceOption = Convert.ToInt32(Console.ReadLine());
            // mainLoop = false;
            if(choiceOption == 1)
            {   
                Duration = 0;
                ActivityName = "Breathing Activity";
                StartingMessage = $"Welcome to the {ActivityName}.";
                EndingMessage = $"You have completed another {Duration} seconds of the {ActivityName}";
                Description = "This activity will help you realax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathing = new BreathingActivity(StartingMessage, EndingMessage, ActivityName, Description, Duration);
                
                int tempDuration = breathing.BreathingMessage();
                activity.Spinner();
                breathing.BreathingTimer(tempDuration);
                Console.Clear();
            }
            else if(choiceOption == 2)
            {
                activity.Spinner();
            }
            else if(choiceOption == 3)
            {

            }
            else if(choiceOption == 4)
            {
                mainLoop = false;
            }
            else
            {
                Console.WriteLine("Please choose the correct option. Thank You!");
            }
        }
    }
}