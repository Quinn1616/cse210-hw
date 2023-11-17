using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {       
        List<Goal> goalsList = new List<Goal>();
        int totalPoints = 0;
        bool loop = true;
        while (loop == true)
        {
            Console.WriteLine($"\nYou have {totalPoints} points.\n");
            
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (userChoice == 1)
            {                      
                Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                Console.Write("What type of goal would you like to create? ");
                int goalChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                
                if (goalChoice == 1)
                {
                    Goal newGoal = new SimpleGoal();
                    Console.WriteLine();
                    Console.WriteLine(newGoal.CreateGoal());
                    goalsList.Add(newGoal);
                }

                else if (goalChoice == 2)
                {
                    Goal newGoal = new EternalGoal();
                    Console.WriteLine();
                    Console.WriteLine(newGoal.CreateGoal());
                    goalsList.Add(newGoal);
                }

                else if (goalChoice == 3)
                {
                    ChecklistGoal newChecklistGoal = new ChecklistGoal();
                    Console.WriteLine();
                    Console.WriteLine(newChecklistGoal.CreateGoal());
                    goalsList.Add(newChecklistGoal);
                }
            }

            else if (userChoice == 2)
            {
                int numberCounter = 1;
                Console.WriteLine("The goals are:");
                foreach (Goal goal in goalsList)
                {
                    if (goal is SimpleGoal)
                    {
                        if (goal.IsComplete)
                        {
                            Console.WriteLine($"  {numberCounter}.  [X]{goal.GoalName} ({goal.GoalDescription})");
                            numberCounter++;
                        }
                        else
                        {
                            Console.WriteLine($"  {numberCounter}.  [ ]{goal.GoalName} ({goal.GoalDescription})");
                            numberCounter++;
                        }
                    }
                    else if (goal is EternalGoal)
                    {
                        if (goal.IsComplete)
                        {
                            Console.WriteLine($"  {numberCounter}.  [ ]{goal.GoalName} ({goal.GoalDescription})");
                            numberCounter++;
                        }
                        else
                        {
                            Console.WriteLine($"  {numberCounter}.  [ ]{goal.GoalName} ({goal.GoalDescription})");
                            numberCounter++;
                        }
                    }
                    else if (goal is ChecklistGoal)
                    {
                        ChecklistGoal currentChecklistGoal = (ChecklistGoal)goal; //?
                        if (goal.IsComplete)
                        {
                            Console.WriteLine($"  {numberCounter}.  [X]{currentChecklistGoal.GoalName} ({currentChecklistGoal.GoalDescription}) -- Currently completed: {currentChecklistGoal.GoalProgress}/{currentChecklistGoal.GoalsNeeded}");
                            numberCounter++;
                        }
                        else
                        {
                            Console.WriteLine($"  {numberCounter}.  [ ]{currentChecklistGoal.GoalName} ({currentChecklistGoal.GoalDescription}) -- Currently completed: {currentChecklistGoal.GoalProgress}/{currentChecklistGoal.GoalsNeeded}");
                            numberCounter++;
                        }
                    }
                }
            }
            
            else if (userChoice == 3)
            {
                string filename = "goals.txt";

                using (StreamWriter outputFile = new StreamWriter(filename))
                {   
                    int savedPoints = 0;
                    foreach (Goal goal in goalsList)
                    {
                        if (goal.IsGoalComplete() == true)
                        {
                            savedPoints += goal.GoalPoints;
                        }
                    } 

                    outputFile.WriteLine(savedPoints);
                    foreach (Goal goal in goalsList)
                    {
                        if (goal.GoalType == "Checklist Goal")
                        {
                            ChecklistGoal currentChecklistGoal = (ChecklistGoal)goal;
                            outputFile.WriteLine($"{currentChecklistGoal.GoalType}-{currentChecklistGoal.GoalName}-{currentChecklistGoal.GoalDescription}-{currentChecklistGoal.GoalPoints}-{currentChecklistGoal.IsComplete}-{currentChecklistGoal.BonusPoints}-{currentChecklistGoal.GoalProgress}-{currentChecklistGoal.GoalsNeeded}");
                        } 
                        else
                        {
                            outputFile.WriteLine($"{goal.GoalType}-{goal.GoalName}-{goal.GoalDescription}-{goal.GoalPoints}-{goal.IsComplete}");
                        }
                    }    
                }
            }

            else if (userChoice == 4)
            {
                string filename = "goals.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
                Goal newGoal = null;

                foreach (string line in lines)
                {
                    string[] parts = line.Split("-");
                    string goalType = parts[0];

                    if (parts.Length >= 5)
                    {
                        
                        if (goalType == "Simple Goal")
                        {
                            newGoal = new SimpleGoal();

                            newGoal.GoalType = goalType;
                            newGoal.GoalName = parts[1];
                            newGoal.GoalDescription = parts[2];
                            newGoal.GoalPoints = Convert.ToInt32(parts[3]);
                            newGoal.IsComplete = Convert.ToBoolean(parts[4]); 
                            goalsList.Add(newGoal);                       
                        }

                        else if (goalType == "Eternal Goal")
                        {
                            newGoal = new EternalGoal();  

                            newGoal.GoalType = goalType;
                            newGoal.GoalName = parts[1];
                            newGoal.GoalDescription = parts[2];
                            newGoal.GoalPoints = Convert.ToInt32(parts[3]);
                            newGoal.IsComplete = Convert.ToBoolean(parts[4]);   
                            goalsList.Add(newGoal);                                               
                        }

                        else if (goalType == "Checklist Goal")
                        {
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            
                            checklistGoal.GoalType = goalType;
                            checklistGoal.GoalName = parts[1];
                            checklistGoal.GoalDescription = parts[2];
                            checklistGoal.GoalPoints = Convert.ToInt32(parts[3]);
                            checklistGoal.IsComplete = Convert.ToBoolean(parts[4]);
                            checklistGoal.BonusPoints = Convert.ToInt32(parts[5]);
                            checklistGoal.GoalProgress = Convert.ToInt32(parts[6]);
                            checklistGoal.GoalsNeeded = Convert.ToInt32(parts[7]);
                            goalsList.Add(checklistGoal);
                        }

                        if (newGoal.IsComplete)
                        {
                            newGoal.IsComplete = true;
                            totalPoints += newGoal.GoalPoints;
                        }
                    }
                }
            }

            else if (userChoice == 5)
            {
                int numberCounter = 1;
                Console.WriteLine("The goals are:");
                foreach (Goal goal in goalsList)
                {
                    Console.WriteLine($"  {numberCounter}. {goal.GoalName} ({goal.GoalDescription})");
                    numberCounter++;
                }

                Console.Write($"Which goal did you accomplish? ");
                int accomplishedGoalIndex = Convert.ToInt32(Console.ReadLine());
                Goal accomplishedGoal = goalsList[accomplishedGoalIndex - 1];

                if (accomplishedGoal is SimpleGoal)
                {
                    int recordPoints = accomplishedGoal.RecordEvent();
                    totalPoints += recordPoints;

                }
                else if (accomplishedGoal is EternalGoal)
                {
                    int recordPoints = accomplishedGoal.RecordEvent();
                    totalPoints += recordPoints;
                }
                else if (accomplishedGoal is ChecklistGoal)
                {
                    int recordPoints = accomplishedGoal.RecordEvent();
                    totalPoints += recordPoints;
                }

            }

            else if (userChoice == 6)
            {
                Console.WriteLine("Goodbye.");
                loop = false;
            }

            else
            {                
                Console.WriteLine("Invalid Input.");           
            }
        }
    }
}