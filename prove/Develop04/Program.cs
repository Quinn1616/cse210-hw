using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
    
        while (true)
        {
            Console.Write("Menu Options:\n  1. Start Breathing Activity\n  2. Start Reflecting Activity\n  3. Start Listing Activity\n  4. Quit\nSelect a choice from the menu: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            int activityLength = 0;

            if (userChoice == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your\nmind and focus on your breathing", activityLength);
                breathingActivity.DisplayStartingMessage();
                breathingActivity.DisplayBreathingMessage();
                breathingActivity.DisplayEndingMessage();
                Console.Clear();
            }

            else if (userChoice == 2)
            {
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", activityLength);
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.DisplayPrompt();
                reflectingActivity.DisplayQuestion();
                reflectingActivity.DisplayEndingMessage();
                Console.Clear();
            }

            else if (userChoice == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", activityLength);
                listingActivity.DisplayStartingMessage();
                listingActivity.DisplayPrompt();
                listingActivity.DisplayEndingMessage();
                Console.Clear();
            }

            else if (userChoice == 4)
            {
                break;
            }

            else
            {
                Console.WriteLine("Error - wrong input. Try again.");
            }
        }
        
        Console.WriteLine("\nHave a good day!");

    }
}