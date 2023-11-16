public abstract class Goal
{
    public bool IsComplete { get; set; }
    public string GoalType { get; set; }
    public string GoalName { get; set; }
    public string GoalDescription { get; set; }
    public int GoalPoints { get; set; }
    //public int TotalPoints { get; set; }
    
    
    public abstract string CreateGoal();    

    public abstract int RecordEvent();

    public abstract bool IsGoalComplete();
    
}