class Word
{   
    public string ScriptureString {get; set;}

    public Word(string verse)
    {
        ScriptureString = verse;
    }
    
    public List<string> StringToList(string ScriptureString)
    {
        string[] tempString = ScriptureString.Split(' ');
        List<string> WordsList = new List<string>(tempString);
        return WordsList;
    }
    public int WordsToRemove()
    {
        Random Rand = new Random();
        int tempRand = Rand.Next(1,5);
        return tempRand;
    }
}
