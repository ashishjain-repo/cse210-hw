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
    public (List<int>, List<int>) UpdateLists(List<int> ContentList, List<int> DeletedTemp, List<int> ContentTemp)
    {   
        int Rand = WordsToRemove();
        DeletedTemp = ContentList.GetRange(0,Rand);
        ContentList.RemoveRange(0,Rand);
        return 
        (   
            ContentList,
            DeletedTemp
        );
    }
}
