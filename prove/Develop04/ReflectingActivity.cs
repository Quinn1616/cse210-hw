public class ReflectingActivity : Activity
{
    private List<string> _promptlist = new List<string>();
    private List<string> _questionList = new List<string>();
    private string _randomPrompt;
    private string _randomQuestion;

    public ReflectingActivity(string name, string description, int length) : base(name, description, legnth)
    {

    }

    public string GetRandomPrompt()
    {
        return "Test Prompt"; //Needs work gets random prompt
    }

    public string GetRandomQuestion()
    {
        return "Test Question"; //Needs work gets random question
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Test DisplayPrompt");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine("Test DisplayQuestion");
    }
}