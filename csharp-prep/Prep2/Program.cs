using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";
        Console.Write("What is your current grade percentage? ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);

        if (grade >= 90) {
            //Console.Write("Congratulations you have an A");
            letterGrade = "A";
        }

        else if (grade >= 80 && grade < 90) {
            //Console.Write("Congratulations you have a B");
            letterGrade = "B";
        }

        else if (grade >= 70 && grade < 80) {
            //Console.Write("Congratulations you have a C");
            letterGrade = "C";
        }

        else if (grade >= 60 && grade < 70) {
            //Console.Write("You have a D, try again in the future.");
            letterGrade = "D";
        }

        else {
            //Console.Write("You have an F, try again in the future.");
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");

        if (grade >= 70) {
            Console.WriteLine("Congratulations you passed the class!");
        }

        else {
            Console.WriteLine("You have failed. Better luck in the future.");
        }


    }
}