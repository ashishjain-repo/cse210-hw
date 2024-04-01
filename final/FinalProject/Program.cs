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
        Dictionary<string, Dictionary<string, string>> JsonData =
            JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(JsonFilePath);
        Dictionary<string, Dictionary<string, Dictionary<string, string>>> AirlineData =
            JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(AirlineJson);

        // Now you can access the deserialized flight data
        string FirstName = "Ashish";
        string LastName = "Jain";
        int Age = 24;
        string Email = "aj9013313373@gmail.com";


        // Part - 1
        Passenger User = new(FirstName, LastName, Age, Email);
        User.Greeting();
        string CountryFrom;
        string CountryTo;
        (CountryFrom, CountryTo) = User.WhereWeGo(JsonData);

        // Part - 2
        Console.WriteLine($"From: {CountryFrom} - To: {CountryTo}");
        Airport UserAirport = new(FirstName, LastName, Age, Email, CountryFrom, CountryTo);
        string AirportFrom;
        string AirportTo;
        (AirportFrom, AirportTo) = UserAirport.ChooseAirport(CountryFrom, CountryTo, JsonData);

        // Part - 3
        Airline UserAirline = new(FirstName, LastName, Age, Email, AirportFrom, AirportTo);
        string Duration;
        string Departure;
        string Arrival;
        (Duration, Departure, Arrival) = UserAirline.FlightDetails(CountryFrom, CountryTo, AirlineData);

        // Part - 4,5,6
        bool Item = true;
        int Choice = 0;
        int Seat = 0;
        while (Item)
        {
            Console.WriteLine("Enter 1 for Business Class and 0 for Economy Class");
            Choice = Convert.ToInt32(Console.ReadLine());
            if (Choice == 0 || Choice == 1)
            {
                Item = false;
            }
        }

        if (Choice == 0)
        {
            Booking UserBooking = new EconomyBooking(Duration, Departure, Arrival);
            Seat = UserBooking.SelectSeat();
        }
        else if (Choice == 1)
        {
            Booking UserBooking = new BusinessBooking(Duration, Departure, Arrival);
            Seat = UserBooking.SelectSeat();
        }

        // Part - 7   
        Receipt UserReceipt = new(FirstName, LastName, Age, Email, CountryFrom, CountryTo, AirportFrom, AirportTo,
            Duration, Departure, Arrival, Seat);
        UserReceipt.ShowReceipt();
    }
}