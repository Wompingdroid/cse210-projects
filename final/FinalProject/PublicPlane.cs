namespace FinalProject;

class PublicPlane : Transportation
{
    int people;
    double time;
    double cost;
    double distance;
    public override double Cost(double d, int amountOfPeople)
    {
        //https://www.cnet.com/personal-finance/planes-trains-cars-and-buses-we-do-the-math-to-discover-the-cheapest-way-to-travel-per-mile/
        //not sure how up to date this is but it doesn't have to be the most accurate.
        cost = d * 0.14 * amountOfPeople;
        return cost;
    }

    public override double Time(double d)
    {
        //https://executiveflyers.com/how-fast-do-planes-fly/
        //ima use the average speed ive seen of around 550 mph
        distance = d;
        time = d / 550;
        return time;
    }

    public override string Display()
    {
        return $"Public Plane- {distance} miles, {time} hours, ${cost}";
    }


    public override double GetAmount()
    {
        System.Console.WriteLine("How many people will be purchasing plane tickets?");
        System.Console.Write("> ");
        people = int.Parse(Console.ReadLine());
        return people;
    }

    public PublicPlane (string name, double distance) :base (name, distance)
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