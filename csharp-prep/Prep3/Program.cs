using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        int num = Convert.ToInt32(Console.ReadLine());
        int guess = -1;
        while (guess != num)
        {
            Console.WriteLine("Guess:");
            guess = Convert.ToInt32(Console.ReadLine());
            if (num > guess)
            {
                Console.WriteLine("Lower");
            }
            else if (num < guess)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}