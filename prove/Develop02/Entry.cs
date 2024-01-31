using System.Xml;
using Microsoft.VisualBasic;

public class Entry
{
    DateTime dt = new DateTime();
    public string _prompt = "";
    public string _response = "";

    public string _date = DateTime.Now.ToString("d/M/yyyy");

    public void AddEntry()
    {
        Console.WriteLine(_date);
    }
    

}