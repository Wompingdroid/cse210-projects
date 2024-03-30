namespace FinalProject;

class Walk : Transportation
{
    public override double Cost(double d, int a)
    {
        return 0;
    }

    public override int Time(int d)
    {
        //https://www.medicalnewstoday.com/articles/average-walking-speed
        int time = d / 5; 
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