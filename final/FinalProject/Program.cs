using System;
using System.Runtime.CompilerServices;
namespace FinalProject;

class Program
{
    private static double totalCost = 0;
    private static double totalTime = 0;

    private static string name;
    private static double distance;

    public static void AddCost(double add)
    {
        totalCost += add;
    }

    public static void AddTime(double add)
    {
        totalTime += add;
    }

    public static double GetTotalCost(){
        return totalCost;
    }
    public static double GetTotalTime(){
        return totalTime;
    }

    static void Main(string[] args)
    {
        // find average speed, cost, cost per person, time, of different modes of transportation

        // user enters a mode of transportation, distance, and amount of people
        // we are assuming the user does have access to each vehicle except Jet, Train, and Public Plane

        // Transportation - speed, cost (cost per person involved in some), time
        
        
        List<Transportation> transportation = new List<Transportation>();

        string userChoice = "7";


        void DisplayAll()
        {
            foreach(var trip in transportation)
            {
                System.Console.WriteLine(trip.Display());
            }
        }

        void AddTrip()
        {
            System.Console.WriteLine("What type of trip are you adding?");
            System.Console.WriteLine("1. Walk");
            System.Console.WriteLine("2. Bike");
            System.Console.WriteLine("3. Car");
            System.Console.WriteLine("4. Train");
            System.Console.WriteLine("5. Public Plane");
            System.Console.WriteLine("6. Jet");
            System.Console.Write("(enter number)> ");
            string transportationChoice = Console.ReadLine();

            System.Console.WriteLine("What is the distance in miles you will be taking this transportation?"); //get distance
            distance = double.Parse(System.Console.ReadLine());

            if (transportationChoice == "1")
            {
                name = "Walk";
                Walk walk = new Walk(name, distance);
                transportation.Add(walk);
                AddCost(walk.GetCost());
                AddTime(walk.GetTime());
            }
            else if (transportationChoice == "2")
            {
                name = "Bike";
                Bike bike = new Bike(name, distance);
                transportation.Add(bike);
                AddCost(bike.GetCost());
                AddTime(bike.GetTime());
            }
            else if (transportationChoice == "3")
            {
                name = "Car";
                Car car = new Car(name, distance);
                transportation.Add(car);
                AddCost(car.GetCost());
                AddTime(car.GetTime());
            }
            else if (transportationChoice == "4")
            {
                name = "Train";
                Train train = new Train(name, distance);
                transportation.Add(train);
                AddCost(train.GetCost());
                AddTime(train.GetTime());
            }
            else if (transportationChoice == "5")
            {
                name = "Public Plane";
                PublicPlane publicPlane = new PublicPlane(name, distance);
                transportation.Add(publicPlane);
                AddCost(publicPlane.GetCost());
                AddTime(publicPlane.GetTime());
            }
            else if (transportationChoice == "6")
            {
                name = "Jet";
                Jet jet = new Jet(name, distance);
                transportation.Add(jet);
                AddCost(jet.GetCost());
                AddTime(jet.GetTime());
            }
            else{
                System.Console.WriteLine("something went wrong with your choice, please enter the number by the mode of transportation.");
            }

        }

        void DisplayMenu()
        {
            System.Console.WriteLine("Please enter the number choice from the choices below");
            System.Console.WriteLine();
            System.Console.WriteLine("1. Add Transportation to Trip");
            System.Console.WriteLine("2. Display Trip");
            System.Console.WriteLine("3. View Total Time");
            System.Console.WriteLine("4. View Total Cost");
            System.Console.WriteLine("5. Quit");
            System.Console.WriteLine();
            System.Console.WriteLine("What would you like to do?");
            System.Console.Write("> ");
            userChoice = System.Console.ReadLine();
        }

        while (userChoice != "5")
        {
            DisplayMenu();
            if (userChoice == "1")
            {
                AddTrip();
            }
            else if (userChoice == "2")
            {
                DisplayAll();
            }
            else if (userChoice == "3")
            {
                System.Console.WriteLine($"{GetTotalTime()} hours");
            }
            else if (userChoice == "4")
            {
                System.Console.WriteLine($"${GetTotalCost()}");
            }
            else if (userChoice == "5")
            {
                break;
            }
            else{
                System.Console.WriteLine("Check your user input. Please input just the number");
            }

        }
        
    }
}