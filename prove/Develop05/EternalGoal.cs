namespace Develop05;

class EternalGoal : Goal
{
    public override void CheckIfComplete()
    {
        
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