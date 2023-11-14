public class EternalGoal : Goal
{
    

    public override int RecordEvent()
    {
        return 1;
    }

    public override bool IsGoalComplete()
    {
        return true;
    }
}