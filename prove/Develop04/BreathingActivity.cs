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
            DisplayBreathingTimer();
            Console.WriteLine();
            
            Console.Write("Now Breath out...");
            DisplayBreathingTimer();
            Console.WriteLine("\n");
        }
    }

    public void DisplayBreathingTimer()
    {
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
}