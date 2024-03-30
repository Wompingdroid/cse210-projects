namespace FinalProject;

class Jet : Transportation
{
    public override double Cost(double time, int amountOfPeople)
    {
        //https://www.afar.com/magazine/how-much-does-a-private-jet-cost
        //I will use $1500 per hour
        //I am assuming that the jet is rented and has enough room for all the people
        double cost = time * 1500;
        return cost;
    }


    public override int Time(int d)
    {
        //https://executiveflyers.com/how-fast-do-planes-fly/
        //I will use the average private jet stats of 400-600 mph and assume the fastest
        int time = d / 600;
        return time; 
    }

    public override string Display()
    {
        throw new NotImplementedException();
    }

    public override int GetAmount()
    {
        throw new NotImplementedException();
    }
}