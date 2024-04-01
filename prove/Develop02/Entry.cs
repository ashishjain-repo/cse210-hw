using System.Xml;
using Microsoft.VisualBasic;
using System.IO;

public class Entry
{
    DateTime dt = new DateTime();
    public string _prompt = "";
    public string _response = "";

    public string _date = DateTime.Now.ToString("d/M/yyyy");

    public void FileCreateAndSave(string FileName, List<string> PromptResponse)
    {
        string DirectoryPath = Environment.CurrentDirectory;
        string FullPath = DirectoryPath + '\\' + FileName;

        StreamWriter writer = new StreamWriter(FullPath);
        foreach (string Prompt in PromptResponse)
        {
            writer.WriteLine(Prompt);
        }

        writer.Close();
        Console.WriteLine("Your File has been succesfully created");
    }

    public void SavedFileLoader(string FileName)
    {
        try
        {
            string DirectoryPath = Environment.CurrentDirectory;
            string FullPath = DirectoryPath + '\\' + FileName;
            StreamReader reader = new StreamReader(FullPath);
            string PromptData = reader.ReadLine();
            while (PromptData != null)
            {
                Console.WriteLine(PromptData);
                PromptData = reader.ReadLine();
            }

            reader.Close();
        }
        catch
        {
            Console.WriteLine($"File Error: File named '{FileName}' does not exist in this directory.\n");
        }
    }
}