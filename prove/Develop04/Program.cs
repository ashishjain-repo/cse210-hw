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
                Duration = 0;
                ActivityName = "Reflecting Activity";
                StartingMessage = $"Welcome to the {ActivityName}.";
                EndingMessage = $"You have completed another {Duration} seconds of the {ActivityName}";
                Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                
                ReflectionActivity reflection = new ReflectionActivity(StartingMessage, EndingMessage, ActivityName, Description, Duration);

                activity.Spinner();
                int tempDuration = reflection.ReflectionMessage();
                reflection.ReflectionPrompt();
                reflection.ReflectionQuestions();
                Console.Clear();
                // int tempDuration = Convert.ToInt32(Console.ReadLine());
                reflection.ReflectionTimed(tempDuration);
                Console.Clear();
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