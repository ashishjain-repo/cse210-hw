public class BusinessBooking : Booking
{
    protected string Duration;
    protected string Departure;
    protected string Arrival;

    public BusinessBooking(string duration, string departure, string arrival) : base(duration, departure, arrival)
    {
        Duration = duration;
        Departure = departure;
        Arrival = arrival;
    }

    public override int SelectSeat()
    {
        int Count = 3;
        int MinValue = 1;
        int MaxValue = 30;
        List<int> Numbers = new List<int>();
        Random rand = new Random();
        for (int i = 0; i < Count; i++)
        {
            int RandomNumber = rand.Next(MinValue, MaxValue + 1);
            Numbers.Add(RandomNumber);
        }

        Console.WriteLine("These are the seats that are available: ");
        bool Temp = true;
        int Choice = 0;
        while (Temp)
        {
            int Index = 0;
            for (int i = 0; i < Numbers.Count; i++)
            {
                Index++;
                Console.WriteLine($"{Index}: Seat Number: {Numbers[i]}");
            }

            Choice = Convert.ToInt32(Console.ReadLine());
            if (Choice < 4 && Choice > 0)
            {
                Temp = false;
            }
            else
            {
                Console.WriteLine("Please select from only given options");
            }
        }

        Choice -= 1;
        int Choose = Numbers[Choice];
        return Choose;
    }
    
}