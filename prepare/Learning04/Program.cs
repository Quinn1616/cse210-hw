using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Quinn Bastian", "Computer Science");
        Console.WriteLine($"{assignment.GetSummary()}\n");

        MathAssignment mathAssignment = new MathAssignment("Quinn Bastian", "Math", "7.3", "8-19");
        Console.WriteLine($"{mathAssignment.GetSummary()} \n{mathAssignment.GetHomeworkList()}\n");

        WritingAssignment writingAssignment = new WritingAssignment("Quinn Bastian", "English", "MockingJay");
        Console.WriteLine($"{writingAssignment.GetSummary()} \n{writingAssignment.GetWritingInformation()}");
    }
}