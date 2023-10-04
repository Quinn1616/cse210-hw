using System;

class Program
{
    static void Main(string[] args)
    {
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
        
    }
}