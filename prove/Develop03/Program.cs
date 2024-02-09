using System;
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
