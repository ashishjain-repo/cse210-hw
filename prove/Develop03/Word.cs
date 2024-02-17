using System.Reflection.Metadata.Ecma335;

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
        int tempRand = Rand.Next(1,6);
        return tempRand;
    }
    
    public List<int> ReturnListIndex(List<string> ContentList)
    {
        List<int> ContentListIndex = new List<int>();
        int Count = ContentList.Count();
        for(int i = 0; i<= Count; i++)
        {
            ContentListIndex.Add(i);
        }

        return ContentListIndex;
    }
    public List<int> RemoveRandomNumbers(List<int> ContentIndexList)
    {
        List<int> DeletetedIndexList = new List<int>();
        Random Rand = new Random();
        int ToRemove = WordsToRemove();

        for (int i = 0; i < ToRemove; i++)
        {
            int randomIndex = Rand.Next(0, ContentIndexList.Count);
            DeletetedIndexList.Add(ContentIndexList[randomIndex]);
            ContentIndexList.RemoveAt(randomIndex);
        }

        return DeletetedIndexList;
    }
}
