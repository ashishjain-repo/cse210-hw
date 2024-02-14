
    class Scripture
    {
        public string ScriptureReference {get; set;}
        public string ScriptureVerse {get; set;}
        public void ShowScripture(string ScriptureReference)
        {
            Console.WriteLine($"Scripture Reference: {ScriptureReference}");
        }
    }