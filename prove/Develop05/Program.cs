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
            string fileName = System.Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                
                foreach (Goal goal in goals)
                {
                    if (goal.GetType() == "EternalGoal")
                    {
                        outputFile.WriteLine(goal.WriteOut());
                    }
                    else if (goal.GetType() == "SimpleGoal")
                    {
                        outputFile.WriteLine(goal.WriteOut());
                    }
                    else if (goal.GetType() == "ChecklistGoal")
                    {
                        outputFile.WriteLine(goal.WriteOut());
                    }
                    else{
                        System.Console.WriteLine("Something went wrong with writing the files");
                    }
                }
            }
        }

        void LoadGoal()
        {
            System.Console.WriteLine("Please enter the name of the file you wish to retrieve.");
            System.Console.Write("> ");
            string getFileName = System.Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(getFileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("::");
                if (parts[0] == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string pointsToComplete = parts[3];

                    EternalGoal newEternalGoal = new EternalGoal(name, description, int.Parse(pointsToComplete));
                    goals.Add(newEternalGoal);
                }
                else if (parts[0] == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string pointsToComplete = parts[3];
                    string check = parts[4];

                    SimpleGoal newSimpleGoal = new SimpleGoal(name, description, int.Parse(pointsToComplete), bool.Parse(check));
                    goals.Add(newSimpleGoal);
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string pointsToComplete = parts[3];
                    string check = parts[4];
                    string bonusPoints = parts[5];
                    string timesToComplete = parts[6];
                    string timesAlreadyCompleted = parts[7];
                    string addedBonus = parts[8];

                    ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, int.Parse(pointsToComplete), bool.Parse(check), int.Parse(bonusPoints), int.Parse(timesAlreadyCompleted), int.Parse(timesToComplete), bool.Parse(addedBonus));
                    goals.Add(newChecklistGoal);
                }
                else
                {
                    System.Console.WriteLine("Something went wrong with typing the child");
                }
                

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