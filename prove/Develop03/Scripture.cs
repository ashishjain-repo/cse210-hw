class Scripture
{
    public string ScriptureReference { get; set; }
    public string ScriptureVerse { get; set; }

    public void ShowScripture(string ScriptureReference, List<string> ScriptureVerse)
    {
        Console.WriteLine(ScriptureReference);
        foreach (string var in ScriptureVerse)
        {
            Console.Write($"{var} ");
        }
    }

    public void ExceptScripture(string ScriptureReference, List<int> ListIndex)
    {
        Console.WriteLine(ScriptureReference);
        foreach (int var in ListIndex)
        {
            Console.Write($"_ ");
        }
    }
}