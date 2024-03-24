namespace FinalProject;
class Bike : Transportation
{

    public override int Cost()
    {
        return 0;
    }

    public override int Time(int t)
    {
        //https://www.informedcyclist.com/average-bike-speed/#:~:text=List%20of%20Average%20Bike%20Speeds%20for%20each%20type,mph%205%20E-bike%20Average%20Speed%20%3D%2015-28%20mph
        int time = t * 15;
        return time;
    }


    

}