using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0) {
            Console.Write("Enter Number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0){
                numbers.Add(userNumber);
            }
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = 0;

        foreach (int number in numbers) {
            if (number > max) {
                max = number;
            }
        }



        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");



    }
}