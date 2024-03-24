namespace FinalProject;

class Walk : Transportation
{
    public override int Cost()
    {
        return 0;
    }

    public override int Time(int t)
    {
        //https://www.medicalnewstoday.com/articles/average-walking-speed
        int time = t * 3; 
        return time;
    }
}