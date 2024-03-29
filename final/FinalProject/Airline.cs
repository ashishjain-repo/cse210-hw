class Airline : Passenger
{
    public string  countryFrom {get; set;}
    public string countryTo {get; set;}

    public Airline(string FirstName, string LastName, int Age, string Email, string CountryFrom, string CountryTo): base(FirstName, LastName, Age, Email)
    {
        CountryFrom = countryFrom;
        CountryTo = countryTo;
    }
    public void FlightDetails(string CountryFrom, string CountryTo, Dictionary<string, Dictionary<string, Dictionary<string, string>>> FlightDetails)
    {
        Console.WriteLine($"You are flying from {CountryFrom} to {CountryTo}");
        foreach (var VARIABLE in FlightDetails[CountryFrom][CountryTo])
        {
            Console.WriteLine(VARIABLE);
        }
        
    }

}