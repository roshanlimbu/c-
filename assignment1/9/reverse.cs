using System;

class Program
{
    static int ReverseNumber(int number)
    {
        int reversed = 0;
        while (number != 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
        return reversed;
    }

    static void Main(string[] args)
    {
        int number = 12345;
        Console.WriteLine($"Reversed number of {number} is {ReverseNumber(number)}");
    }
}
