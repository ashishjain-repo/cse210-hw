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
        
        void Spinner()
        {
            string[] spinnerSymbol = { "+", "|", "/", "-", "\\", "|", "/", "-", "\\", "|" };
            foreach (string temp in spinnerSymbol)
            {
                Console.Write(temp);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
                Console.Clear();
        }
        bool BooleanResult(bool WhileLoop)
        {
            Console.Write("If you confirm this information enter 'Y'. If not enter 'N'");
         string Prompt = Console.ReadLine();
            if (Prompt == "Y" || Prompt == "y")
            {
                WhileLoop = false;
                Console.WriteLine("Your information is Recorded. Thank You :)");
                Spinner();
            }
            else
            {
                Console.WriteLine("Oops!!!");
                Spinner();
            }
            return WhileLoop;
        }
        string JsonFilePath = File.ReadAllText("serve.json");
        string AirlineJson = File.ReadAllText("airline.json");
        Dictionary<string, Dictionary<string, string>> JsonData =
            JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(JsonFilePath);
        Dictionary<string, Dictionary<string, Dictionary<string, string>>> AirlineData =
            JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(AirlineJson);

        bool Basic = true;
        string FirstName = null;
        string LastName = null;
        int Age = 0;
        string Email = null;
        while(Basic)
        {
            Console.Write("Please Enter Your First Name: ");
            FirstName = Console.ReadLine();
            Console.Write("Please Enter Your Last Name: ");
            LastName = Console.ReadLine();
            Console.Write("Please Enter Your Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Your Full Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Full Name: {0} {1}, Age: {2}, and Email: {3}",FirstName, LastName, Age, Email);
            //Console.Write("If you confirm this information enter 'Y'. If not enter 'N'");
            Basic = BooleanResult(Basic);
            //Basic = (Pass == "Y" || Pass == "y") ? false : true;
            //if(Basic == true) { Spinner(); }
        }


        // Part - 1
        bool PartOne = true;
        string CountryFrom = null;
        string CountryTo = null;
        while (PartOne) 
        {
            Passenger User = new(FirstName, LastName, Age, Email);
            User.Greeting();
            (CountryFrom, CountryTo) = User.WhereWeGo(JsonData);
            Console.WriteLine("Travelling Country, From: {0}, To: {1}",CountryFrom, CountryTo);
            PartOne = BooleanResult(PartOne);
        }
        

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
        Payment UserPayment = new(FirstName, LastName, Age, Email, AirlineData, CountryFrom, CountryTo);
        string Amount = UserPayment.FlightCost();

        // Part - 8   
        Receipt UserReceipt = new(FirstName, LastName, Age, Email, CountryFrom, CountryTo, AirportFrom, AirportTo,
            Duration, Departure, Arrival, Seat, Amount);
        UserReceipt.ShowReceipt();
    }
}