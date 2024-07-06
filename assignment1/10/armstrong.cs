using System;

class Program
{
    static bool IsArmstrong(int number)
    {
        int originalNumber = number;
        int result = 0;
        int n = number.ToString().Length;
        while (number != 0)
        {
            int digit = number % 10;
            result += (int)Math.Pow(digit, n);
            number /= 10;
        }
        return result == originalNumber;
    }

    static void Main(string[] args)
    {
        int number = 153;
        Console.WriteLine(IsArmstrong(number) ? $"{number} is an Armstrong number." : $"{number} is not an Armstrong number.");
    }
}
