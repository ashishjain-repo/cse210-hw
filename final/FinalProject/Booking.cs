public abstract class Booking
{
    public string duration { get; set; }
    public string departure { get; set; }
    public string arrival { get; set; }

    public Booking(string Duration, string Departure, string Arrival)
    {
        Duration = duration;
        Departure = departure;
        Arrival = arrival;
    }

    public abstract int SelectSeat();
    
}