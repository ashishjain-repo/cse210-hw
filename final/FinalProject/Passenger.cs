using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Security.Cryptography;


class Passenger
{
    protected string _passengerFirstName { get; set; }
    protected string _passengerLastName { get; set; }
    protected int _passengerAge { get; set; }
    protected string _passengerEmail { get; set; }
    public Passenger(string FirstName, string LastName, int Age, string Email)
    {
        FirstName = _passengerFirstName;
        LastName = _passengerLastName;
        Age = _passengerAge;
        Email = _passengerEmail;
    }

    public string WhereWeGo(Dictionary<string, Dictionary<string, string>> data)
    {
        
        IEnumerable<string> keys = data.Keys;
        bool mainBool = true;
        string country = null;
        while (mainBool)
        {
            int count = 1;
            Console.WriteLine("Where do you want to visit from the following:- ");
            foreach (string key in keys)
            {
                Console.WriteLine($"{count}: {key}");
                count++;
            }
            Console.Write("Please Choose one: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    country = keys.ElementAtOrDefault(0);
                    mainBool = false;
                    break;
                case 2:
                    country = keys.ElementAtOrDefault(1);
                    mainBool = false;
                    break;
                case 3:
                    country = keys.ElementAtOrDefault(2);
                    mainBool = false;
                    break;
                case 4:
                    country = keys.ElementAtOrDefault(3);
                    mainBool = false;
                    break;
                case 5:
                    country = keys.ElementAtOrDefault(4);
                    mainBool = false;
                    break;
                default:
                    Console.WriteLine("Please choose the correct option :)");
                    break;
            }
        }
        return country;
    }
}