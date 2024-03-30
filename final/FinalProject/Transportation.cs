using System.Runtime.InteropServices;

namespace FinalProject;

abstract class Transportation
{
    double distance;

    public abstract double Cost(double distance, int amount);
    public abstract int Time( int distance);
    public abstract string Display();

    public abstract int GetAmount();
    public void SetDistance(){
        System.Console.WriteLine("What is the distance you will use this form of transportation?");
        System.Console.Write("> ");
        distance = double.Parse(Console.ReadLine());
    }


}