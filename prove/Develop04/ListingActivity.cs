public class ListingActivity : Activity
{
    private List<string> _promptlist = new List<string>();
    private string _randomPrompt;
    private int _anwerCount;

    public ReflectingActivity(string name, string description, int length) : base(name, description, legnth)
    {

    }

    public string GetRandomPrompt()
    {
        return "Test Prompt"; //Needs work gets random prompt
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Test DisplayPrompt");
    }

    public void DisplayNumAnswers()
    {
        Console.WriteLine("Test DisplayNumAnswers");
    }
}