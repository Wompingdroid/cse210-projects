namespace FinalProject;

class Car : Transportation
{
    public override double Cost(double d, int amountOfCars)
    {
        //https://exchange.aaa.com/automotive/aaas-your-driving-costs/
        //I will use the average cost per mile of $0.70
        double cost = d * .7 * amountOfCars;
        return cost; 
    }

    public override int Time(int d)
    {
        int time = d / 60;
        return time;
    }

    public override string Display()
    {
        throw new NotImplementedException();
    }

    public override int GetAmount()
    {
        System.Console.WriteLine("How many cars will be used?");
        System.Console.Write("> ");
        int cars = int.Parse(Console.ReadLine());
        return cars;
    }

}