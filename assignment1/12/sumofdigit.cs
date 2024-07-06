using System;

class Program
{
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int number = 12345;
        Console.WriteLine($"Sum of digits of {number} is {SumOfDigits(number)}");
    }
}
