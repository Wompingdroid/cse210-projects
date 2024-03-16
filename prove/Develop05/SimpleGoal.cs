namespace Develop05;

class SimpleGoal : Goal
{
    public override string GetType()
    {
        type = "SimpleGoal";
        return type;
    }
    public override void CheckIfComplete()
    {
        isComplete = true;
    }

    public override string WriteOut()
    {
        return $"{GetType()}::{GetName()}::{GetDescription()}::{GetPointsToComplete()}::{GetIsComplete()}";
    }

    public override int AddScore()
    {
        if (isComplete == false){
            return pointsToComplete;
        }
        else{
            return 0;
        }
    }

    public override void DisplayGoal()
    {
        string check;
        if (isComplete == true)
        {
            check = "✓";
        } 
        else{
            check = "X";
        }
        System.Console.WriteLine($"{name}, {description}, {pointsToComplete}, [{check}]");   
    }

    public SimpleGoal (string name, string description, int pointsToComplete, bool isComplete) :base(name, description, pointsToComplete, isComplete)
    {
        
    }

}