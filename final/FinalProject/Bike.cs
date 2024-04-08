using System.Runtime.InteropServices;

namespace FinalProject;
class Bike : Transportation
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
        //https://www.informedcyclist.com/average-bike-speed/#:~:text=List%20of%20Average%20Bike%20Speeds%20for%20each%20type,mph%205%20E-bike%20Average%20Speed%20%3D%2015-28%20mph
        time = d / 15;
        return time;
    }

    public override string Display()
    {
        return $"Bike- {distance} miles, {time} hours, ${cost}";
    }

    public override double GetAmount()
    {
        throw new NotImplementedException();
    }


    public Bike (string name, double distance) :base (name, distance)
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