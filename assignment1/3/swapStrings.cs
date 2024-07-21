using System;

class swapString
{
    static void Main(String[]args)
    {
        string str1 = "Roshan";
        string str2 = "Limbu";
        string temp;
        Console.WriteLine($"Before swapping: str1 = {str1}, str2 = {str2}");

        temp = str1;
        str1 = str2;
        str2 = temp;

        Console.WriteLine($"After swapping: str1 = {str1}, str2 = {str2}");
    }
}
