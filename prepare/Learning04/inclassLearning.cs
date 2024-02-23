public class Vehicle 
{
protected string make;
protected string model;
protected int miles;

public Vehicle (string make, string model, int miles)
{
this.make = make;
this.model = model;
this.miles = miles;
}
}

public  class Car : Vehicle
{
    public Car (string make, string model, int miles) : base(make, model, miles){
    }
}

public class Truck : Vehicle
{
    private int towing;
    public Truck(string make, string model, int miles, int towing) : base(make, model, miles)
    {
        this.towing = towing;
    }

}