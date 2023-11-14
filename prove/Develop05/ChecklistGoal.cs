public class ChecklistGoal : Goal
{
    public int GoalsCompleted { get; set; }
    //public int BonusPoints { get; set; }

    public override string CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string bonusTimes = Console.ReadLine();
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusPoints = Console.ReadLine();
        

        return $"{goalName} - {goalDescription} - {goalPoints} - {bonusTimes} - {bonusPoints}";
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