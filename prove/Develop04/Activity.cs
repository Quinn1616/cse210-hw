public class Activity 
{
    private string _activityName;
    private string _description;
    private int _activityLength;

    public Activity(string name, string description, int length)
    {
        _activityName = name;
        _description = description;
        _activityLength = length;
    }

    public int GetActivityLength()
    {
        return _activityLength;
    }

    public int DisplayStartingMessage()
    {
        Console.Write($"\nWelcome to the {_activityName}.\n\n{_description}\n\nHow long, in seconds, would you like for your session? ");
        _activityLength = Convert.ToInt32(Console.ReadLine());
        return _activityLength;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!\n");
        Thread.Sleep(500);
        Console.WriteLine($"You have completed another {_activityLength} seconds of the {_activityName}.");
        PauseSpinner();
    }

    public void PauseSpinner()
    {
        int count = 0;
        while (count != 1)
        {
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("—");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            count++;
        }
        Console.WriteLine();
    }

    public void PauseCountdown()
    {
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");

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