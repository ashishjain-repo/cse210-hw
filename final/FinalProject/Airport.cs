class Airport : Passenger
{
    public string countryFrom { get; set; }
    public string countryTo { get; set; }

    public Airport(string FirstName, string LastName, int Age, string Email, string CountryFrom, string CountryTo) :
        base(FirstName, LastName, Age, Email)
    {
        CountryFrom = countryFrom;
        CountryTo = countryTo;
    }

    public (string, string) ChooseAirport(string CountryFrom, string CountryTo,
        Dictionary<string, Dictionary<string, string>> data)
    {
        IEnumerable<string> cFrom = data[CountryFrom].Keys;
        IEnumerable<string> cTo = data[CountryTo].Keys;
        IEnumerable<string> aFrom = data[CountryFrom].Values;
        IEnumerable<string> aTo = data[CountryTo].Values;
        var fromKeyVal = cFrom.Zip(aFrom, (key, value) => new { Name = key, Code = value });
        var toKeyVal = cTo.Zip(aTo, (key, value) => new { Name = key, Code = value });
        string fromChoice = null;
        string toChoice = null;
        bool fromBool = true;
        bool toBool = true;
        while (fromBool)
        {
            foreach (var pair in fromKeyVal)
            {
                Console.WriteLine($"Airport: {pair.Name} => Airport Code: {pair.Code}");
            }

            Console.Write("Please enter the departure airport code: ");
            fromChoice = Console.ReadLine();
            if (!fromKeyVal.Any(pair => pair.Code == fromChoice))
            {
                fromBool = true;
                Console.WriteLine("Please choose only given options.");
            }
            else
            {
                fromBool = false;
            }
        }

        while (toBool)
        {
            foreach (var pair in toKeyVal)
            {
                Console.WriteLine($"Airport: {pair.Name} => Airport Code: {pair.Code}");
            }

            Console.Write("Please enter the arrival airport code: ");
            toChoice = Console.ReadLine();
            if (!toKeyVal.Any(pair => pair.Code == toChoice))
            {
                toBool = true;
                Console.WriteLine("Please choose only given options.");
            }
            else
            {
                toBool = false;
            }
        }

        return (fromChoice, toChoice);
    }
}