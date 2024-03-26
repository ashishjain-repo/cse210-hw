class Airline : Passenger
{
    public string  airportFrom {get; set;}
    public string airportTo {get; set;}

    public Airline(string FirstName, string LastName, int Age, string Email, string AirportFrom, string AirportTo): base(FirstName, LastName, Age, Email)
    {
        AirportFrom = airportFrom;
        AirportTo = airportTo;
    }
    public void ShowAirports(string AirportFrom, string AirportTo)
    {
        Console.WriteLine($"You are flying from {AirportFrom} to {AirportTo}");
    }

}