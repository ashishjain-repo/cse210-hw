using System;

Entry entry = new Entry();
PromptGenerator PromptGen = new PromptGenerator();

List<string> Prompts = new List<string>();
string[] tempPrompt = { "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit" };
Prompts.AddRange(tempPrompt);
List<string> PromptsResponse = new List<string>();
bool WhileLoop = true;

while (WhileLoop)
{
    Console.WriteLine("Please select the following choices: ");
    foreach (string Prompt in Prompts)
    {
        Console.WriteLine(Prompt);
    }
    Console.WriteLine("What would you like to do?");
    int LocalResponse = Convert.ToInt32(Console.ReadLine());
    switch (LocalResponse)
    {
        case 1:
            entry._prompt = PromptGen.UniquePromptGenerator();
            Console.WriteLine(entry._prompt);
            entry._response = Console.ReadLine();
            string TempResponseHolder = $"Date:{entry._date} - Prompt:{entry._prompt}\nResponse: {entry._response}";
            PromptsResponse.Add(TempResponseHolder);
            break;
        case 2:
            foreach (string Data in PromptsResponse)
            {
                Console.WriteLine(Data + "\n");
            }
            break;
        case 3:
            break;
        case 4:
            Console.WriteLine("What is the filename");
            string FileName = Console.ReadLine();
            entry.FileCreateAndSave(FileName,PromptsResponse);
            break;
        case 5:
            WhileLoop = false;
            break;
    }
}
