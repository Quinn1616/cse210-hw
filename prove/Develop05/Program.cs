using System;

class Program
{
    static void Main(string[] args)
    {
        Goal goal = new Goal();
        Console.WriteLine($"\nYou have {goal.UserScore} points.\n");
        
        bool loop = true;
        while (loop == true)
        {
            //Console.WriteLine("Test Loop");
            //loop = false;
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userChoice == 1)
            {
                //Create New Goal
                //continue;
                Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                Console.Write("What type of goal would you like to create? ");
                int goalChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                
                if (goalChoice == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    Console.WriteLine(simpleGoal.CreateGoal());
                    Console.WriteLine();

                }

                else if (goalChoice == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    Console.WriteLine(eternalGoal.CreateGoal());
                    Console.WriteLine();
                }

                else if (goalChoice == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    Console.WriteLine(checklistGoal.CreateGoal());
                    Console.WriteLine();
                }

            }

            else if (userChoice == 2)
            {
                //List Goals
                continue;
            }

            else if (userChoice == 3)
            {
                //Save Goals
                continue;
            }

            else if (userChoice == 4)
            {
                //Load Goals
                continue;
            }

            else if (userChoice == 5)
            {
                //Record Event
                continue;
            }

            else if (userChoice == 6)
            {
                Console.WriteLine("Goodbye.");
                loop = false;
            }

            else
            {
                Console.WriteLine("Wrong input.");
            }



        }

        //create functions that will save and load the list to a file



    }
}