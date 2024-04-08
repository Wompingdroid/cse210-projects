namespace FinalProject;

class Jet : Transportation
{
    double cost;
    double time;
    double distance;
    public override double Cost(double time, int amountOfPeople)
    {
        //https://www.afar.com/magazine/how-much-does-a-private-jet-cost
        //I will use $1500 per hour
        //I am assuming that the jet is rented and has enough room for all the people
        cost = time * 1500;
        return cost;
    }


    public override double Time(double d)
    {
        //https://executiveflyers.com/how-fast-do-planes-fly/
        //I will use the average private jet stats of 400-600 mph and assume the fastest
        distance = d;
        time = d / 600;
        return time; 
    }

    public override string Display()
    {
        return $"Jet- {distance} miles, {time} hours, ${cost}";
    }

    public override double GetAmount()
    {
        throw new NotImplementedException();
    }


    public Jet (string name, double distance) :base (name, distance)
    {
        Cost(distance, 0);
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