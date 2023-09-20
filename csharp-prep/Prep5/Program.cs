using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptuserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);



        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName() {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptuserNumber() {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number) {
            return number * number;
        }

        static void DisplayResult(string name, int number) {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
        

    }
}