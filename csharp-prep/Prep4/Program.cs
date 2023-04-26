using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            if (userNumber != 0)
            {
                nums.Add(userNumber);
            }
        }
        int sum = nums.Sum();
        Console.WriteLine($"The sum is {sum}.");
        int len = nums.Count();
        int avg = sum/len;
        Console.WriteLine($"The average is {avg}.");
        int max = nums[0];

        foreach (int number in nums)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}