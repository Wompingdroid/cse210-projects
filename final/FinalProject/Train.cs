namespace FinalProject;
class Train : Transportation
{
    public override double Cost(double d, int amountOfPeople)
    {
        //https://www.thepricer.org/u-s-train-travel-cost/#:~:text=Depending%20on%20how%20early%20you%20book%20the%20tickets,between%20%2460%20and%20%2480%20for%20a%20one-way%20ticket.
        //trains fluctuate so much in price im going to just say the ticket costs $120
        return 120 * amountOfPeople;
    }

    public override int Time(int d)
    {
        //https://www.trainconductorhq.com/how-fast-do-trains-go-really-thats-fast/
        //im using the passenger train section and will take the 100 mph for commute
        int time = d / 100;
        return time;

    }

    public override string Display()
    {
        throw new NotImplementedException();
    }

    public override int GetAmount()
    {
        System.Console.WriteLine("How many people will be getting train tickets?");
        System.Console.Write("> ");
        int people = int.Parse(Console.ReadLine());
        return people;
    }
}