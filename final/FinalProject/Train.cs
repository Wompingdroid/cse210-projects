namespace FinalProject;
class Train : Transportation
{
    public override int Cost()
    {
        //https://www.thepricer.org/u-s-train-travel-cost/#:~:text=Depending%20on%20how%20early%20you%20book%20the%20tickets,between%20%2460%20and%20%2480%20for%20a%20one-way%20ticket.
        //ima use $80
        throw new NotImplementedException();
    }

    public override int Time(int t)
    {
        //https://www.trainconductorhq.com/how-fast-do-trains-go-really-thats-fast/
        //im using the passenger train section and will take the 100 mph for commute
        int time = t * 100;
        return time;

    }



}