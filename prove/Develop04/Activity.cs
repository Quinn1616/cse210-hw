public class Activity 
{
    private string _activityName;
    private string _description;
    private int _activityLength;
    private bool _continueRunning;

    public Activity(string name, string description, int length)
    {
        _activityName = name;
        _description = description;
        _activityLength = length;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("test starting message");
    }

    public int GetActivityLength()
    {
        return _activityLength;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("test ending message");
    }

    public void PauseSpinner()
    {
        Console.WriteLine("Test spinner");
    }

    publiv void PauseCountdown()
    {
        Console.WriteLine("Test countdown");
    }

}