namespace FinalProject;
class Train : Transportation
{
    double time;
    double distance;
    double cost;
    int people;
    public override double Cost(double d, int amountOfPeople)
    {
        //https://www.thepricer.org/u-s-train-travel-cost/#:~:text=Depending%20on%20how%20early%20you%20book%20the%20tickets,between%20%2460%20and%20%2480%20for%20a%20one-way%20ticket.
        //trains fluctuate so much in price im going to just say the ticket costs $120
        distance = d;
        cost = 120 *amountOfPeople;
        return cost;
    }

    public override double Time(double d)
    {
        //https://www.trainconductorhq.com/how-fast-do-trains-go-really-thats-fast/
        //im using the passenger train section and will take the 100 mph for commute
        time = d / 100;
        return time;

    }

    public override string Display()
    {
        return $"Train- {distance} miles, {time} hours, ${cost}";
    }

    public override double GetAmount()
    {
        System.Console.WriteLine("How many people will be getting train tickets?");
        System.Console.Write("> ");
        people = int.Parse(Console.ReadLine());
        return people;
    }

    public Train (string name, double distance) :base (name, distance)
    {
        GetAmount();
        Cost(distance, people);
        Time(distance);
    }

    public override double GetCost()
    {
        return cost;
    }
    public override double GetTime()
    {
        return time;
    }

}