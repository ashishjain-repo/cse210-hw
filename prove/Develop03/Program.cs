/* using System;
using System.Xml;
class Program
{
    static void Main(string[] args)
{
    var reference = new Reference();
    List<string[]> temp = reference.RandomScripture();
    string[] verse = temp[0];
    Console.WriteLine(temp[0][1]);
    Console.WriteLine(string.Join(",",verse));

}
}
 */
using System;
using System.IO;
using System.Text.Json;

namespace ReadScripturesJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Read the JSON file
                string jsonString = File.ReadAllText("scripture.json");

                // Deserialize the JSON into RootObject
                RootObject root = JsonSerializer.Deserialize<RootObject>(jsonString);

                if (root != null && root.Verses != null)
                {
                    // Access the verses list
                    var verses = root.Verses;

                    // Iterate through each verse
                    foreach (var verse in verses)
                    {
                        int id = verse.Id;
                        string reference = verse.Reference;
                        string verseText = verse.VerseText;

                        Console.WriteLine($"ID: {id}, Reference: {reference}, Verse: {verseText}");
                    }
                }
                else
                {
                    Console.WriteLine("JSON file is empty or has incorrect structure.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
