class Airport : Passenger
{
    public string countryFrom { get; set; }
    public string countryTo { get; set; }
    public Airport(string FirstName, string LastName, int Age, string Email, string CountryFrom, string CountryTo): base(FirstName, LastName, Age, Email)
    {
        CountryFrom = countryFrom;
        CountryTo = countryTo;
    }
    public void ChooseAirport(string CountryFrom, string CountryTo)
    {
        
    }
}