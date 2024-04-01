class Receipt : Passenger
{
    
    public Receipt(string FirstName, string LastName, int Age, string Email, string CountryFrom, string CountryTo, string AirportFrom, string AirportTo, string Duration, string Departure, string Arrival, int Seat) :
        base(FirstName, LastName, Age, Email)
    {
        
    }

    public void ShowReceipt()
    {
        Console.WriteLine($"{PassengerFirstName}");
    }
}