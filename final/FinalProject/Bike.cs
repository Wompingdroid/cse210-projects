namespace FinalProject;
class Bike : Transportation
{

    public override double Cost(double d, int a)
    {
        return 0;
    }

    public override int Time(int d)
    {
        //https://www.informedcyclist.com/average-bike-speed/#:~:text=List%20of%20Average%20Bike%20Speeds%20for%20each%20type,mph%205%20E-bike%20Average%20Speed%20%3D%2015-28%20mph
        int time = d / 15;
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