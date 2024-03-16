namespace Develop05;

abstract class Goal
{
    protected string type;
    public abstract string GetType();
    
    protected string name;

    abstract public int AddScore();
    public string GetName(){
        return name;
    }
    protected string description;
    public string GetDescription(){
        return description;
    }
    protected bool isComplete;
    public bool GetIsComplete(){
        return isComplete;
    }
    protected int pointsToComplete;
    public int GetPointsToComplete(){
        return pointsToComplete;
    }

    public abstract void CheckIfComplete();

    public abstract string WriteOut();

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