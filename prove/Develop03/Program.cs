using System;
using System.Xml;
class Program
{
    static void Main(string[] args)
{
    string filePath = "data.xml";
    var doc = new XmlDataDocument();
    doc.Load(filePath);
    XmlNode root = doc.DocumentElement;
    foreach(XmlNode node in root.ChildNodes)
    {
        string id = node.SelectSingleNode("id").InnerText;
        string name = node.SelectSingleNode("name").InnerText;

        Console.WriteLine($"ID: {id}, Name: {name}");
    }

}
}
