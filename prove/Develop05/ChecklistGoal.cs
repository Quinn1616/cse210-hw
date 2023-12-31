public class ChecklistGoal : Goal
{
    public int GoalsNeeded { get; set; }
    public int GoalProgress { get; set; }
    public int BonusPoints { get; set; }

    public override string CreateGoal()
    {
        GoalType = "Checklist Goal";
        Console.Write("What is the name of your goal? ");
        GoalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        GoalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        GoalPoints = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        GoalsNeeded = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        BonusPoints = Convert.ToInt32(Console.ReadLine());
        GoalProgress = 0;
        return $"{GoalType} - {GoalName} - {GoalDescription} - {GoalPoints} - {BonusPoints} - {GoalProgress} - {GoalsNeeded}";
    }

    public override int RecordEvent()
    {
        GoalProgress++;
        
        if (GoalProgress >= GoalsNeeded)
        {
            Console.WriteLine($"Congratulations! You have earned {GoalPoints} points!");
            IsComplete = true;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GoalPoints} points!");
        }
        
        return GoalPoints;
    }

    public override bool IsGoalComplete()
    {
        return IsComplete;
    }
}