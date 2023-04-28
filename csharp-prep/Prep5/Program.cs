using System;

class Program
{
    static void Main(string[] args)
    {
        string userName = PromptUserName();
        int num = PromptUserNumber();
        int Square = SquareNumber(num);
        DisplayResult(userName, Square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int Unum)
    {
        int Square = (Unum * Unum);
        return Square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}