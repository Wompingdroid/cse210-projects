namespace Develop05;

class EternalGoal : Goal
{
    
    public override string GetType()
    {
        type = "EternalGoal";
        return type;
    }
    public override void CheckIfComplete()
    {
        
    }
    public override string WriteOut(){

        return $"{GetType()}::{GetName()}::{GetDescription()}::{GetPointsToComplete()}";

    }

    public override int AddScore()
    {
        return pointsToComplete;
    }

    public override void DisplayGoal()
    {
        System.Console.WriteLine($"{name}, {description}, {pointsToComplete}");
    }

    public EternalGoal (string name, string description, int pointsToComplete) :base(name, description, pointsToComplete)
    {
        
    }



}