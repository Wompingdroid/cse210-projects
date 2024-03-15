using System.ComponentModel.DataAnnotations;

namespace Develop05;

class ChecklistGoal : Goal
{
public override int AddScore()
    {
        if (timesAlreadyCompleted +1 == timesToComplete && addedBonus == false){
            addedBonus = true;
            return pointsToComplete + bonusPoints;
        }
        else if (isComplete == false){
            return pointsToComplete;
        }

        else{
            return 0;
        }
    }


    public override void CheckIfComplete()
    {
        timesAlreadyCompleted += 1;
        if (timesAlreadyCompleted == timesToComplete){
            isComplete = true;
        }
        
    }

    public override void DisplayGoal()
    {
        System.Console.WriteLine($"{name}, {description}, {pointsToComplete}, bonus:{bonusPoints}, {timesAlreadyCompleted}/{timesToComplete}");
    }

    protected int bonusPoints;
    public int GetBonusPoints(){
        return bonusPoints;
    }
    protected bool addedBonus = false;
    protected int timesToComplete;
    private int timesAlreadyCompleted;
    public int GetTimesAlreadyCompleted()
    {
        return timesAlreadyCompleted;
    }
    public void SetTimesAlreadyCompleted(int newTimesAlreadyCompleted)
    {
        timesAlreadyCompleted = newTimesAlreadyCompleted;
    }


    public ChecklistGoal (string name, string description, int pointsToComplete, bool isComplete, int bonusPoints, int timesToComplete, int timesAlreadyCompleted, bool addedBonus) :base(name, description, pointsToComplete, isComplete)
    {
        this.bonusPoints = bonusPoints; 
        this.timesToComplete = timesToComplete;
        this.timesAlreadyCompleted = timesAlreadyCompleted;
        this.addedBonus = addedBonus;
    }

}