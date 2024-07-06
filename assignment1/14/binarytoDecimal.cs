using System;

class Program
{
    static int BinaryToDecimal(string binaryNumber)
    {
        return Convert.ToInt32(binaryNumber, 2);
    }

    static void Main(string[] args)
    {
        string binaryNumber = "11001";
        Console.WriteLine($"Decimal equivalent of {binaryNumber} is {BinaryToDecimal(binaryNumber)}");
    }
}
