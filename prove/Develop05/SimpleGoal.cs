public class SimpleGoal : Goal
{
    public SimpleGoal()
    {

    }


    public override int RecordEvent()
    {
        return 1;
    }

    public override bool IsGoalComplete()
    {
        return true;
    }

}