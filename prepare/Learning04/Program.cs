using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Quinn Bastian", "Computer Science", "7.3", "8-19");

        Console.WriteLine($"{mathAssignment.GetSummary()} \n{mathAssignment.GetHomeworkList()}");
    }
}