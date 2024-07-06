using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        int number = 17;
        bool isPrime = IsPrime(number);
        if (isPrime)
            Console.WriteLine($"{number} is prime.");
        else
            Console.WriteLine($"{number} is composite.");
    }
}
