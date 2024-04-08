namespace FinalProject;

class Walk : Transportation
{
    double time;
    double cost = 0;
    double distance;
    public override double Cost(double d, int a)
    {
        distance = d;
        return 0;
    }

    public override double Time(double d)
    {
        //https://www.medicalnewstoday.com/articles/average-walking-speed
        time = d / 5; 
        return time;
    }

    public override string Display()
    {
        return $"Walk- {distance} miles, {time} hours, $0";
    }

    public override double GetAmount()
    {
        throw new NotImplementedException();
    }

    public Walk (string name, double distance) :base (name, distance)
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