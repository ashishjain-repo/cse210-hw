using System.Security.Cryptography;

class Reference
{
    public int ScriptId {get; set;}
    public string ScriptReference {get; set;}
    public string ScriptVerse {get; set;}
    public string[,] Scripture {get; set;}
    /* public string[,] Scripture = {
            {
                "1"
                ,"2 Nephi 5:1"
                ,"Behold, it came to pass that I, Nephi, did cry much unto the Lord my God, because of the anger of my brethren."
            },
            {
                "2"
                ,"Mosiah 3:6"
                ,"And he shall cast out devils, or the evil spirits which dwell in the hearts of the children of men."
            },
            {
                "3"
                ,"Ether 12:1"
                ,"And it came to pass that the days of Ether were in the days of Coriantumr; and Coriantumr was king over all the land."
            }
        }; */
    public Random RandomNum = new Random();
    public Reference(int id, string reference, string verse, string[,] allScripture, int randomNumber)
    {
        ScriptId = id;
        ScriptReference = reference;
        ScriptVerse = verse;
        string[,] Scripture = {
            {
                "1"
                ,"2 Nephi 5:1"
                ,"Behold, it came to pass that I, Nephi, did cry much unto the Lord my God, because of the anger of my brethren."
            },
            {
                "2"
                ,"Mosiah 3:6"
                ,"And he shall cast out devils, or the evil spirits which dwell in the hearts of the children of men."
            },
            {
                "3"
                ,"Ether 12:1"
                ,"And it came to pass that the days of Ether were in the days of Coriantumr; and Coriantumr was king over all the land."
            }
        };
        
    }

}