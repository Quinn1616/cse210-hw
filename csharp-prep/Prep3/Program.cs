using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        //Console.Write("What is the magic number? ");
        //int number = int.Parse(Console.ReadLine());

        do {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < number) {
                Console.WriteLine("Higher");
            }
            if (guess > number) {
                Console.WriteLine("Lower");
            }
        } while (guess != number);

        Console.WriteLine("Correct");

    

        




    }
}