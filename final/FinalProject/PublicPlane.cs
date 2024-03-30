namespace FinalProject;

class PublicPlane : Transportation
{
    public override double Cost(double d, int amountOfPeople)
    {
        //https://www.cnet.com/personal-finance/planes-trains-cars-and-buses-we-do-the-math-to-discover-the-cheapest-way-to-travel-per-mile/
        //not sure how up to date this is but it doesn't have to be the most accurate.
        double cost = d * 0.14 * amountOfPeople;
        return cost;
    }

    public override int Time(int d)
    {
        //https://executiveflyers.com/how-fast-do-planes-fly/
        //ima use the average speed ive seen of around 550 mph
        int time = d / 550;
        return time;
    }

    public override string Display()
    {
        throw new NotImplementedException();
    }


    public override int GetAmount()
    {
        System.Console.WriteLine("How many people will be purchasing plane tickets?");
        System.Console.Write("> ");
        int people = int.Parse(Console.ReadLine());
        return people;
    }
}