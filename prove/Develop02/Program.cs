using System;

class Program{
static void Main(String[] args)
{
    Entry entry = new Entry();
    PromptGenerator promptGen = new PromptGenerator();
    
    List<string> Prompts = new List<string>();
    string[] tempPrompt = {"1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"};
    Prompts.AddRange(tempPrompt);
    
    bool WhileLoop = true;

    while (WhileLoop)
    {
        Console.WriteLine("Please select the following choices: ");
        foreach (string Prompt in Prompts)
        {
            Console.WriteLine(Prompt);
        }
        int LocalResponse = Convert.ToInt32(Console.ReadLine());    
        switch(LocalResponse)
        {
            case 1: 
                
                break;
            case 2: 
                break;
            case 3:         
                break;
            case 4: 
                break;
            case 5: 
                WhileLoop = false;
                break;
        }
    }
    
    
}
}