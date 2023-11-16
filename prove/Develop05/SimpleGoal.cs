public class SimpleGoal : Goal
{
    public SimpleGoal()
    {

    }

    public override string CreateGoal()
    {
        GoalType = "Simple Goal";
        Console.Write("What is the name of your goal? ");
        GoalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        GoalDescription = Console.ReadLine();
        //Console.Write("What is the amount of points associated with this goal? ");
        //GoalPoints = Convert.ToInt32(Console.ReadLine());
        GoalPoints = 50;
        Console.WriteLine();
        
        return $"{GoalType} - {GoalName} - {GoalDescription} - {GoalPoints}";
    }

    public override int RecordEvent()
    {
        int pointsEarned = 50;
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        //TotalPoints += pointsEarned;
        IsComplete = true;
        return pointsEarned;
    }

    public override bool IsGoalComplete()
    {
        return IsComplete;
        //return true;
    }

}