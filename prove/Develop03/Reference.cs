using System;
using System.Diagnostics;
using System.Security.Cryptography;

class Reference
{
    public int ScriptId { get; set; }
    public string ScriptReference { get; set; }
    public string ScriptVerse { get; set; }

    public Reference()
    {

    }
    public Reference(int id, string reference, string verse)
    {
        ScriptId = id;
        ScriptReference = reference;
        ScriptVerse = verse;
    }

    public (int, string, string) RandomVerse(int ScriptID, string ScriptReference, string ScriptVerse) // Change method name
    {
        string[,] myScripture = new string[3, 3];
        // Hardcoded values
        myScripture[0, 0] = "1";
        myScripture[0, 1] = "2 Nephi 5:1";
        myScripture[0, 2] = "Behold, it came to pass that I, Nephi, did cry much unto the Lord my God, because of the anger of my brethren.";
        myScripture[1, 0] = "2";
        myScripture[1, 1] = "Mosiah 3:6";
        myScripture[1, 2] = "And he shall cast out devils, or the evil spirits which dwell in the hearts of the children of men.";
        myScripture[2, 0] = "3";
        myScripture[2, 1] = "Ether 12:1";
        myScripture[2, 2] = "And it came to pass that the days of Ether were in the days of Coriantumr; and Coriantumr was king over all the land.";

        Random Rand = new Random();
        int tempRand = Rand.Next(0, 3);


        int chosenIndex = tempRand; // Assuming "2 Nephi 5:1"

        return
        (
        ScriptID = Convert.ToInt32(myScripture[chosenIndex,0]),
        ScriptReference = myScripture[chosenIndex,1],
        ScriptVerse = myScripture[chosenIndex,2]
        );

    }
}
