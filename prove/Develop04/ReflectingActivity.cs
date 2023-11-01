public class ReflectingActivity : Activity
{
    private List<string> _promptlist = new List<string>
    {
        "Think of a time when you did something really difficult",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questionList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectingActivity(string name, string description, int length) : base(name, description, length)
    {
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_promptlist.Count);
        return _promptlist[randomIndex];
    }

    public string GetRandomQuestion()
    {
        Random random1 = new Random();
        int randomIndex1 = random1.Next(_questionList.Count);
        return _questionList[randomIndex1];
    }

    public void DisplayPrompt()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseSpinner();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---\n");

        Console.Write("When you have something in mind, press enter to continue");
        Console.ReadLine();
    }

    public void DisplayQuestion()
    {
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PauseCountdown();
        Console.Write("\n");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetActivityLength());

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.Write(GetRandomQuestion());
            PauseSpinner();
        }
        Console.Write("\n");
    }
}