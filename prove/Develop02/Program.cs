using System;

class Program{
static void Main(String[] args)
{
    Entry entry = new Entry();
    
    List<string> prompts = new List<string>();
    string[] tempPrompt = {"1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"};
    prompts.AddRange(tempPrompt);
    
    bool whileLoop = true;

    while (whileLoop)
    {
        Console.WriteLine("Please select the following choices: ");
        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
        }
        int localResponse = Convert.ToInt32(Console.ReadLine());    
        switch(localResponse)
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
                whileLoop = false;
                break;
        }
    }
    
    
}
}