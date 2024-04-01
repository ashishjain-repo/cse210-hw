using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Security.Cryptography;


class Passenger
{
    public string PassengerFirstName { get; set; }
    public string PassengerLastName { get; set; }
    public int PassengerAge { get; set; }
    public string PassengerEmail { get; set; }

    public Passenger(string FirstName, string LastName, int Age, string Email)
    {
        FirstName = PassengerFirstName;
        LastName = PassengerLastName;
        Age = PassengerAge;
        Email = PassengerEmail;
    }

    public void Greeting()
    {
        Console.WriteLine($"Hello {PassengerLastName}, {PassengerFirstName}");
        Console.WriteLine("Welcome to First Fly Tomorrow Flight Booking: ");
    }

    public string LocalIterator(IEnumerable<string> keys, int choice)
    {
        string country = null;
        switch (choice)
        {
            case 1:
                country = keys.ElementAtOrDefault(0);
                break;
            case 2:
                country = keys.ElementAtOrDefault(1);

                break;
            case 3:
                country = keys.ElementAtOrDefault(2);

                break;
            case 4:
                country = keys.ElementAtOrDefault(3);

                break;
            case 5:
                country = keys.ElementAtOrDefault(4);
                break;
            default:
                Console.WriteLine("Please choose the correct option :)");
                country = null;
                break;
        }

        return country;
    }

    public (string, string) WhereWeGo(Dictionary<string, Dictionary<string, string>> data)
    {
        IEnumerable<string> keys = data.Keys;
        string countryFrom = null;
        string countryTo = null;
        int count = 1;
        Console.WriteLine("THese are the places we fly:- ");
        foreach (string key in keys)
        {
            Console.WriteLine($"{count}: {key}");
            count++;
        }

        bool choice = true;
        int flyFrom = 0;
        int flyTo = 0;
        while (choice)
        {
            Console.Write("Please Choose from where you want to fly: ");
            flyFrom = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please choose to where you want to fly:");
            flyTo = Convert.ToInt32(Console.ReadLine());
            choice = (flyFrom == flyTo) ? true : false;
        }

        countryFrom = LocalIterator(keys, flyFrom);
        countryTo = LocalIterator(keys, flyTo);
        return (countryFrom, countryTo);
    }
}