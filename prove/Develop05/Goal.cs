public class Goal
{
    //public List<string> GoalsList { get; set; }
    public string SingleGoal { get; set; }
    public bool Complete { get; set; }
    public int UserScore { get; set; }
    //public int MyProperty { get; set; }

    public Goal()
    {
        UserScore = 0;
    }

    public virtual string CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();
        Console.WriteLine();

        SingleGoal = $"{goalName} - {goalDescription} - {goalPoints}";
        return $"{goalName} - {goalDescription} - {goalPoints}";
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Test Display Goals");
    }

    //Marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event
    public virtual int RecordEvent()
    {
        return 1;
    }

    public virtual bool IsGoalComplete()
    {
        return true;
    }

    public void DisplayScore()
    {
        Console.WriteLine("Test Display Score");
    }

}