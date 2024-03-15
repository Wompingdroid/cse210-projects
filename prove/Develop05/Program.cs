using System;
using System.Security.Cryptography.X509Certificates;
namespace Develop05;

using System.Collections.Concurrent;
using System.IO;

class Program
{
    
    static int currentUserScore = 0;
    public static void SetCurrentUserScore(int add){
        currentUserScore += add;
    }
    
    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();
        string userChoice = "7";

        void SaveGoal()
        {
            System.Console.WriteLine("Please give the file name of your file to save it.");
            System.Console.WriteLine("> ");
            string fileName = System.Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                //outputFile.WriteLine("This will be the first line in the file.");
                
                // You can use the $ and include variables just like with Console.WriteLine
                //string color = "Blue";
                //outputFile.WriteLine($"My favorite color is {color}");
            }
        }

        void LoadGoal()
        {
            System.Console.WriteLine("Please enter the name of the file you wish to retrieve.");
            System.Console.Write("> ");
            string getFileName = System.Console.ReadLine();
            string filename = getFileName;
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("::");

                //string firstName = parts[0];
                //string lastName = parts[1];
            }
        }

        void DisplayAllGoals()
        {
            foreach(var goal in goals)
            {
                goal.DisplayGoal();
            }
        }

        void RecordEvent()
        {
            int i = 1;
            foreach(var goal in goals)
            {
                System.Console.WriteLine($"{i}. {goal.GetName()}");
                i += 1;
            }
            System.Console.WriteLine("Which goal did you complete? \n> ");
            string goalChoice = Console.ReadLine();
            int add = goals[int.Parse(goalChoice)-1].AddScore();
            SetCurrentUserScore(add);
            goals[int.Parse(goalChoice)-1].CheckIfComplete();
        }

        void CreateGoal()
        {
            System.Console.WriteLine("What type of goal would you like to make?");
            System.Console.WriteLine("   1. Simple goal");
            System.Console.WriteLine("   2. Eternal goal");
            System.Console.WriteLine("   3. Checklist goal\n");
            System.Console.WriteLine("(please enter the number)");
            string goalChoice = "0";
            goalChoice = System.Console.ReadLine();
            if (goalChoice == "1") // Simple goal
            {   
                System.Console.WriteLine("What is the name of your simple goal?");
                string name = Console.ReadLine();
                System.Console.WriteLine("What is the description of the goal?");
                string description = Console.ReadLine();
                System.Console.WriteLine("How many points will this give you?");
                string points = Console.ReadLine();
                bool notComplete = false;

                SimpleGoal newSimpleGoal = new SimpleGoal(name, description, int.Parse(points), notComplete);
                goals.Add(newSimpleGoal);
            }
            else if (goalChoice == "2") // eternal goal
            {
                System.Console.WriteLine("What is the name of your eternal goal?");
                string name = Console.ReadLine();
                System.Console.WriteLine("What is the description of the goal?");
                string description = Console.ReadLine();
                System.Console.WriteLine("How many points will this give you?");
                string points = Console.ReadLine();

                EternalGoal newEternalGoal = new EternalGoal(name, description, int.Parse(points));
                goals.Add(newEternalGoal);
            }
            else if (goalChoice == "3") // checklist goal
            {
                System.Console.WriteLine("What is the name of your checklist goal?");
                string name = Console.ReadLine();
                System.Console.WriteLine("What is the description of the goal?");
                string description = Console.ReadLine();
                System.Console.WriteLine("How many points will this give you?");
                string points = Console.ReadLine();
                bool notComplete = false;
                System.Console.WriteLine("How many times would you like to complete this goal?");
                string timesToComplete = Console.ReadLine();
                System.Console.WriteLine("How many bonus points will this give you?");
                string bonusPoints = Console.ReadLine();


                ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, int.Parse(points), notComplete, int.Parse(bonusPoints), int.Parse(timesToComplete), 0, false);
                goals.Add(newChecklistGoal);
            }
            else{
                System.Console.WriteLine("something went wrong with choosing a goal");
            }
            
        }

        void DisplayMenu()
        {
            System.Console.WriteLine("Menu Options:");
            System.Console.WriteLine("  1. Create Goal");
            System.Console.WriteLine("  2. List Goals");
            System.Console.WriteLine("  3. Save Goals");
            System.Console.WriteLine("  4. Load Goals");
            System.Console.WriteLine("  5. Record Event");
            System.Console.WriteLine("  6. Quit");
            System.Console.Write("Select a choice from the list above: ");
            userChoice =System.Console.ReadLine();
        }


        while (userChoice != "6")
        {
            System.Console.WriteLine($"Your current score is {currentUserScore}");
            DisplayMenu();
            if (userChoice == "1")
            {
                CreateGoal();
            }
            else if (userChoice == "2")
            {
                DisplayAllGoals();
            }
            else if (userChoice == "3")
            {
                SaveGoal();
            }
            else if (userChoice == "4")
            {
                LoadGoal();
            }
            else if (userChoice == "5")
            {
                RecordEvent();
            }
            else if (userChoice == "6")
            {
                break;
            }
            else{
                System.Console.WriteLine("something went wrong in the menu");
            }
        }


    }
}