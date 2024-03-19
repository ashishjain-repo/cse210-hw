using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;


class Passenger
{
    protected string _passengerFirstName {get; set;}
    protected string _passengerLastName {get; set;}
    protected int _passengerAge {get; set;}
    protected string _passengerEmail {get; set;}
    public Passenger(string FirstName, string LastName, int Age, string Email)
    {
        FirstName = _passengerFirstName;
        LastName = _passengerLastName;
        Age = _passengerAge;
        Email = _passengerEmail;
    }

    public void WhereWeGo()
    {
        string jsonFilePath = File.ReadAllText("serve.json");
        Dictionary<string, Dictionary<string, string>> data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(jsonFilePath);
        Console.WriteLine(data);

        
        
    }
}