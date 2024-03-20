class Airport : Passenger
{
    protected string _country { get; set; }
    public Airport(string FirstName, string LastName, int Age, string Email, string Country): base(FirstName, LastName, Age, Email)
    {
        Country = _country;
    }
    public void ChooseAirport(string Country)
    {
        
    }
}