public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int length) : base(name, description, length)
    {

    }

    public void DisplayBreathingMessage()
    {
        Console.WriteLine("Test breathing message")
    }

    public void DisplayBreathingTimer()
    {
        Console.WriteLine("Test breathing timer")
    }

}