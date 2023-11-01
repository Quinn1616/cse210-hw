public class ListingActivity : Activity
{
    private List<string> _promptlist = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int length) : base(name, description, length)
    {
    
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_promptlist.Count);
        return _promptlist[randomIndex];
    }

    public void DisplayPrompt()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseSpinner();
        Console.WriteLine("List as many responses you can to the following prompt: \n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        PauseCountdown();
        Console.WriteLine();

        int answerCount = 0;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetActivityLength());
        
        while (DateTime.Now < futureTime)
        {
            string answer = Console.ReadLine();
            answerCount++;
        }

        Console.WriteLine($"\nYou listed {answerCount} items!\n");
    }
    
}