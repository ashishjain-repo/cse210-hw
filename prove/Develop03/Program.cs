using System;

class Program
{
    static void Main(string[] args)
    {
        int ContentId = 0;
        string ContentReference = "";
        string ContentVerse = "";
        Reference Ref1 = new Reference(ContentId, ContentReference, ContentVerse);
        (ContentId, ContentReference, ContentVerse) =
            Ref1.RandomVerse(Ref1.ScriptId, Ref1.ScriptReference, Ref1.ScriptVerse);

        /* Scripture Scr1 = new Scripture();
        Scr1.ShowScripture(reference); */

        Word Wor1 = new Word(ContentVerse);
        List<string> ScriptureSplits = new List<string>();

        ScriptureSplits = Wor1.StringToList(ContentVerse);

        List<int> ContentListIndex = new List<int>();
        List<int> DeletedListIndex = new List<int>();

        List<int> ContentTemp = new List<int>();
        List<int> DeletedTemp = new List<int>();

        List<string> TempIteration = new List<string>();

        Scripture Src1 = new Scripture();


        ContentListIndex = Wor1.ReturnListIndex(ScriptureSplits);
        ContentTemp.AddRange(ContentListIndex);
        Boolean WhileLoop = true;

        while (WhileLoop)
        {
            try
            {
                DeletedTemp = Wor1.RemoveRandomNumbers(ContentTemp);
                DeletedListIndex.AddRange(DeletedTemp);
                DeletedListIndex.Sort();

                TempIteration = Wor1.IndexReplacer(ScriptureSplits, DeletedListIndex);

                Src1.ShowScripture(ContentReference, TempIteration);
                // Debugging
                // Console.WriteLine($"\nContentList: {ContentListIndex.Count}\nDeletedList: {DeletedListIndex.Count}");
                // Debugging
                if (ContentListIndex.Count == DeletedListIndex.Count)
                {
                    WhileLoop = false;
                }

                Console.WriteLine("\nPress Enter to continue or type 'quit' to finsih");
                string Broker = Console.ReadLine();
                if (Broker == "quit" || Broker == "QUIT")
                {
                    WhileLoop = false;
                }
            }
            catch (Exception e)
            {
                WhileLoop = false;
                Src1.ExceptScripture(ContentReference, ContentListIndex);
                // Console.WriteLine(e.Message);
            }
        }
    }
}