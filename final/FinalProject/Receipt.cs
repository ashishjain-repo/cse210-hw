class Receipt : Passenger
{
    private string countryFrom { get; set; }
    private string countryTo { get; set; }
    private string airportFrom { get; set; }
    private string airportTo { get; set; }
    private string duration { get; set; }
    private string departure { get; set; }
    private string arrival {get; set; }
    private int seat { get; set; }
    private string Amount { get;set; }
    public Receipt(string FirstName, string LastName, int Age, string Email, string CountryFrom, string CountryTo, string AirportFrom, string AirportTo, string Duration, string Departure, string Arrival, int Seat, string amount) :
        base(FirstName, LastName, Age, Email)
    {
        countryFrom = CountryFrom;
        countryTo = CountryTo;
        airportFrom = AirportFrom;
        airportTo = AirportTo;
        duration = Duration;
        departure = Departure;
        arrival = Arrival;
        seat = Seat;
        Amount = amount;
    }

    public void ShowReceipt()
    {
        Console.WriteLine("Your Flight Details: ");
        Console.WriteLine($"Full Name: {PassengerFirstName} {PassengerLastName}");
        Console.WriteLine($"Age: {PassengerAge}");
        Console.WriteLine($"Email: {PassengerEmail}");
        Console.WriteLine($"You Are Travelling From {countryFrom} To {countryTo}");
        Console.WriteLine($"Your flight will departure from {airportFrom} at {departure}");
        Console.WriteLine($"Your flight will arrive at {airportTo} at {arrival}");
        Console.WriteLine($"Your seat no: {seat}");
        Console.WriteLine($"Total Duration: {duration}");
        Console.WriteLine($"Total payable amount: {Amount}");
        
    }
}