using System;
class Program
{
    static void Main(string[] args)
    {
        int id = 0;
        string reference = "";
        string verse = "";
        Reference Ref1 = new Reference(id, reference, verse);
        Reference ref2 = new Reference();
        (id, reference, verse) = Ref1.RandomVerse(Ref1.ScriptId, Ref1.ScriptReference, Ref1.ScriptVerse);
        Console.WriteLine(verse);
        // Ref1.RandomVerse();
    
    }
}

