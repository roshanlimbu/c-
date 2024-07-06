using System;
class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, temp;
        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
    static void Main(string[] args)
    {
        int n = 10;
        int result = Fibonacci(n);
        Console.WriteLine($"The {n}th term of the Fibonacci series is: {result}");
    }
}
