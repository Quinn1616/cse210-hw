using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        
        //Create promps
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        
        //1. show menu
        //2. get menu choice
        //3. decide what to do
        //...
        //create a new entry
        Entry entry = new Entry();

        //gets date from computer. ToShortDateString converts int type to string
        entry.EntryDate = DateTime.Now.ToShortDateString();
        entry.Prompt = ""; //value of prompt displayed to user
        entry.UserResponse = ""; //value user entered

        //create a new Journal object
        Journal journal = new Journal();
        journal.Name = ""; //user entered name
        journal.Entries.Add(entry);


        //save to file

        //read from file


















        /*
        DateTime currentDateTime = DateTime.Now;
        string dateText = currentDateTime.ToShortTimeString();

        Entry entry1 = new Entry();
        entry1.date = dateText; 
    


        bool continueLoop = true;
        while (continueLoop == true)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");
            Console.Write("What would you like to do? ");
    
            String stringUserInput = Console.ReadLine();
            int userInput = int.Parse(stringUserInput);

            //Displays a prompt and allows the user to input their answer.
            if (userInput == 1) {
                break;
            }

            //Displays all of the entries writted so far.
            else if (userInput == 2) {
                break;
            }
            
            //Load the file which imports the entries into a list into the journal class.
            else if (userInput == 3) {
                break;
            }

            //Saves the entries list into the file given by the user.
            else if (userInput == 4) {
                break;
            }

            //Quits the loop and program. 
            else if (userInput == 5) {
                //Console.WriteLine("Test");
                continueLoop = false;
            }

            //Handles error from wrong input.
            else {
                Console.WriteLine("Wrong Input");
            }
        }
    */ 
    }
}