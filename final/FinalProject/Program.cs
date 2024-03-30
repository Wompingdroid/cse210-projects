using System;
using System.Runtime.CompilerServices;
namespace FinalProject;

class Program
{
    private static double totalCost = 0;
    private static int totalTime = 0;

    public static void AddCost(int add)
    {
        totalCost += add;
    }

    public static void AddTime(int add)
    {
        totalTime += add;
    }

    public double GetTotalCost(){
        return totalCost;
    }
    public int GetTotalTime(){
        return totalTime;
    }

    static void Main(string[] args)
    {
        // find average speed, cost, cost per person, time, of different modes of transportation

        // user enters a mode of transportation, distance, and amount of people
        // we are assuming the user does have access to each vehicle except Jet, Train, and Public Plane

        // Transportation - speed, cost (cost per person involved in some), time
        
        
        List<Transportation> transportation = new List<Transportation>();


        
    }
}