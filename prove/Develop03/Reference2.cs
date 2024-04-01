using System;
using System.Collections.Generic;

namespace ReadScripturesJSON
{
    public class Verse
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string VerseText { get; set; }
    }

    public class RootObject
    {
        public List<Verse> Verses { get; set; }
    }
}