public class EternalGoal : Goal
{
    public override string CreateGoal()
    {
        GoalType = "Eternal Goal";
        Console.Write("What is the name of your goal? ");
        GoalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        GoalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        GoalPoints = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        return $"{GoalType} - {GoalName} - {GoalDescription} - {GoalPoints}";
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GoalPoints} points!");
        IsComplete = true;
        return GoalPoints;
    }

    public override bool IsGoalComplete()
    {
        return IsComplete;
    }
}