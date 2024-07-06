using System;
class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    static void Main(string[] args)
    {
        int n = 10;
        int result = Fibonacci(n);
        Console.WriteLine($"The {n}th term of the Fibonacci series is: {result}");
    }
}
