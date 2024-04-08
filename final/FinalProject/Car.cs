namespace FinalProject;

class Car : Transportation
{
    int cars;
    double time;
    double distance;
    double cost;
    public override double Cost(double d, int amountOfCars)
    {
        //https://exchange.aaa.com/automotive/aaas-your-driving-costs/
        //I will use the average cost per mile of $0.70
        distance = d;
        cost = d * .7 * amountOfCars;
        return cost; 
    }

    public override double Time(double d)
    {
        time = d / 60;
        return time;
    }

    public override string Display()
    {
        return $"Car- {distance} miles, {time} hours, ${cost}";
    }

    public override double GetAmount()
    {
        System.Console.WriteLine("How many cars will be used?");
        System.Console.Write("> ");
        cars = int.Parse(Console.ReadLine());
        return cars;
    }


    public Car (string name, double distance) :base (name, distance)
    {
        GetAmount();
        Cost(distance, cars);
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