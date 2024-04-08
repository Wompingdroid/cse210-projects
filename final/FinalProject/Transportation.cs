using System.Runtime.InteropServices;

namespace FinalProject;

abstract class Transportation
{   
    double time;
    double cost;
    double distance;
    string name;

    public abstract double Cost(double distance, int amount);
    public abstract double Time( double distance);
    public abstract string Display();

    public abstract double GetAmount();
    public void SetDistance(){
        System.Console.WriteLine("What is the distance you will use this form of transportation?");
        System.Console.Write("> ");
        distance = double.Parse(Console.ReadLine());
    }

    public Transportation(string name, double distance){
        this.distance = distance;
        this.name = name; 
    }

    public abstract double GetCost();
    public abstract double GetTime();
}