using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string JsonFilePath = File.ReadAllText("serve.json");
        string AirlineJson = File.ReadAllText("airline.json");
        Dictionary<string, Dictionary<string, string>> JsonData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(JsonFilePath);
        Dictionary<string, Dictionary<string, string>> AirlineData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(AirlineJson);

        // Now you can access the deserialized flight data
        string FirstName = "Ashish";
        string LastName = "Jain";
        int Age = 24;
        string Email = "aj9013313373@gmail.com";


        // Part - 1
        Passenger User = new(FirstName, LastName, Age, Email);
        User.Greeting();
        string CountryFrom; string CountryTo;
        (CountryFrom, CountryTo) = User.WhereWeGo(JsonData);

        // Part - 2
        Console.WriteLine($"From: {CountryFrom} - To: {CountryTo}");
        Airport UserAirport = new(FirstName, LastName, Age, Email, CountryFrom, CountryTo);
        string AirportFrom; string AirportTo;
        (AirportFrom, AirportTo) = UserAirport.ChooseAirport(CountryFrom, CountryTo, JsonData);

        // Part - 3
        Airline UserAirline = new(FirstName, LastName, Age, Email, AirportFrom, AirportTo);
        UserAirline.ShowAirports(AirportFrom, AirportTo);
    }
}