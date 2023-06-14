using System;

namespace Develop02
{
    class Prompts
    {
        static void Main(string[] args)
        {
            var random = new Random();
            string x = "s";
            List<string> prompts = new List<string>();
            prompts.Add("Who was the most interesting person I interacted with today?");
            prompts.Add("What was the best part of my day?");
            prompts.Add("How did I see the hand of the Lord in my life today?");
            prompts.Add("What was the strongest emotion I felt today?");
            prompts.Add("If I had one thing I could do over today, what would it be?");
            int choice = random.Next(4);
            x = prompts[choice];
            Console.WriteLine(x);//?
        }
    }
}