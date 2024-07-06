using System;

class Program
{
    static bool IsPalindrome(int number)
    {
        int original = number;
        int reversed = 0;
        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
        return original == reversed;
    }

    static void Main(string[] args)
    {
        int number = 12321;
        Console.WriteLine(IsPalindrome(number) ? $"{number} is a palindrome." : $"{number} is not a palindrome.");
    }
}
