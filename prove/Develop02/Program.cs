using System;
using System.Threading.Tasks.Dataflow;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        //Create prompts
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        

        //create a new Journal object
        Journal journal = new Journal();


        //1. show menu
        //2. get menu choice
        //3. decide what to do

        bool continueLoop = true;
        while (continueLoop == true)
        { 
            //User interface
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");
            Console.Write("What would you like to do? ");

            //User input
            String stringUserInput = Console.ReadLine();
            int userInput = int.Parse(stringUserInput);

            //create a new entry
            Entry entry = new Entry();    

            //Displays a prompt and allows the user to input their answer.
            if (userInput == 1) {
                Console.WriteLine("");

                //generates a random index for random prompt
                Random random = new Random();
                int randomIndex = random.Next(prompts.Count);

                //generates a random string for random prompt
                string randomPrompt = prompts[randomIndex];

                //enters date, prompt, and response into the entry object
                entry.EntryDate = DateTime.Now.ToShortDateString();
                entry.Prompt = randomPrompt;
                Console.WriteLine(randomPrompt);
                entry.UserResponse = Console.ReadLine(); //value user entered
                
                //adds the entry object into the Entries list in the Journal Class
                journal.Entries.Add(entry);
                
                Console.WriteLine("");
            }

            //Displays all of the entries writted so far.
            else if (userInput == 2) {
                journal.DisplayJournal();
            }
            
            //Load the file which imports the entries into a list into the journal class.
            else if (userInput == 3) {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                //needs work
                
            }

            //Saves the entries list into the file given by the user.
            else if (userInput == 4) {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename)) 
                {
                    foreach (var journalEntry in journal.Entries) {
                        outputFile.WriteLine($"{journalEntry.EntryDate} - {journalEntry.Prompt} \n{journalEntry.UserResponse};");
                    }
                }

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

    }
}



        /*  
        //create a new entry
        Entry entry = new Entry();

        //gets date from computer. ToShortDateString converts int type to string
        entry.EntryDate = DateTime.Now.ToShortDateString();
        entry.Prompt = randomString; //value of prompt displayed to user
        //entry.UserResponse = "test response"; //value user entered
        entry.AddEntryInfo(entry.EntryDate, entry.Prompt, entry.UserResponse);
        

        //create a new Journal object
        Journal journal = new Journal();
        journal.Name = "Quinn Bastian"; //user entered name
        journal.Entries.Add(entry);
        //journal.DisplayEntry(entry.EntryDate, entry.Prompt, entry.UserResponse);

        */



