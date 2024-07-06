using System;

class Program
{
    static string DecimalToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 2);
    }

    static void Main(string[] args)
    {
        int decimalNumber = 25;
        Console.WriteLine($"Binary equivalent of {decimalNumber} is {DecimalToBinary(decimalNumber)}");
    }
}
