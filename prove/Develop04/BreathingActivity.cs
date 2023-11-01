public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int length) : base(name, description, length)
    {
    }

    public void DisplayBreathingMessage()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseSpinner();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetActivityLength());
        
        while (DateTime.Now < futureTime)
        {
            Console.Write("Breath in...");
            PauseCountdown();
            Console.WriteLine();
            
            Console.Write("Now Breath out...");
            PauseCountdown();
            Console.WriteLine("\n");
        }
    }
}