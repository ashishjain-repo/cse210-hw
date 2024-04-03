class Payment : Passenger
{
    protected Dictionary<string, Dictionary<string, Dictionary<string, string>>> PaymentJson { get; set; }
    protected string CountryFrom { get; set; }
    protected string CountryTo { get; set; }

    public Payment(string FirstName, string LastName, int Age, string Email, Dictionary<string, Dictionary<string, Dictionary<string, string>>> paymentJson, string countryFrom, string countryTo) : base(FirstName, LastName, Age, Email)
    {
        PaymentJson = paymentJson;
        CountryFrom = countryFrom;
        CountryTo = countryTo;
    }
    public string FlightCost()
    {
        string Amount = PaymentJson[CountryFrom][CountryTo]["TotalCost"];
        return Amount;
    }

}