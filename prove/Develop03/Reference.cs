using Microsoft.VisualBasic;    
using System.Xml;

class Reference
{
    // Getter and Setter
    private string _scriptureReference;
    public string ScriptureReference
    {
        get { return _scriptureReference; }
        set { _scriptureReference = value; }
    }
    private string _scriptureVerse;
    public string ScriptureVerse
    {
        get { return _scriptureVerse; }
        set { _scriptureVerse = value; }
    }
    private List<string[]> _scriptureContent = new List<string[]>();
    public List<string[]> ScriptureContent
    {
        get { return _scriptureContent; }
        set { _scriptureContent = value; }
    }
    private int _scriptureNumber;
    public int ScriptureNumber
    {
        get { return _scriptureNumber; }
        set { _scriptureNumber = value; }
    }
    public List<string[]> RandomScripture()
    {   string filePath = "./data.xml";
        var doc = new XmlDataDocument();
        doc.Load(filePath);
        XmlNode root = doc.DocumentElement;
        foreach(XmlNode node in root.ChildNodes)
        {
            int index = Convert.ToInt32(node.SelectSingleNode("index").InnerText);
            ScriptureReference = node.SelectSingleNode("id").InnerText;
            ScriptureVerse = node.SelectSingleNode("content").InnerText;
            // Console.WriteLine($"Index:{index}\nReference{ScriptureReference}\nVerse{ScriptureVerse}");
            string[] VerseValues = {Convert.ToString(index), ScriptureReference, ScriptureVerse};
            ScriptureContent.Add(VerseValues);
        }

        return ScriptureContent;
    }
}
