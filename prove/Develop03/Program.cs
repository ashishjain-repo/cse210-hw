using System;
class Program
{
    static void Main(string[] args)
    {
        int id = 0;
        string reference = "";
        string verse = "";
        Reference Ref1 = new Reference(id, reference, verse);
        (id, reference, verse) = Ref1.RandomVerse(Ref1.ScriptId, Ref1.ScriptReference, Ref1.ScriptVerse);
        Scripture Scr1 = new Scripture();
        Scr1.ShowScripture(reference);
        Word Wor1 = new Word(verse);
        List<string> ScriptureSplits = new List<string>();
        ScriptureSplits = Wor1.StringToList(verse);
        foreach (var word in ScriptureSplits)
        {
            Console.Write($"{word} ");
        }
        
    
    }
}

