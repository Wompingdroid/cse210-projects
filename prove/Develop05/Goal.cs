namespace Develop05;

abstract class Goal
{
    protected string name;

    abstract public int AddScore();
    public string GetName(){
        return name;
    }
    protected string description;
    protected bool isComplete;
    public bool GetIsComplete(){
        return isComplete;
    }
    protected int pointsToComplete;
    public int GetPointsToComplete(){
        return pointsToComplete;
    }

    public abstract void CheckIfComplete();

    public abstract void DisplayGoal();

    public Goal(string name, string description, int pointsToComplete, bool isComplete)
    {
        this.name = name;
        this.description = description;
        this.pointsToComplete = pointsToComplete;
        this.isComplete = isComplete;
    }
    public Goal(string name, string description, int pointsToComplete)
    {
        this.name = name;
        this.description = description;
        this.pointsToComplete = pointsToComplete;
    }

}