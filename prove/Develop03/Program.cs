using System;

class Program
{
    static void Main(string[] args)
    {
        string reference = "John 11:35";
        string text = "Jesus wept.";
        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine($"{scripture.GetReference()}: {scripture.GetRenderedText()}\n");
        
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideWords();
            Console.Clear();
            Console.WriteLine($"{scripture.GetReference()}: {scripture.GetRenderedText()}\n");
           
        }
    }
}