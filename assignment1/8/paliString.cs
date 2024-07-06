using System;

class Program
{
    static bool IsPalindrome(string str)
    {
        str = str.ToLower().Replace(" ", "");
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right]) return false;
            left++;
            right--;
        }
        return true;
    }

    static void Main(string[] args)
    {
        string str = "mam";
        Console.WriteLine(IsPalindrome(str) ? $"'{str}' is a palindrome." : $"'{str}' is not a palindrome.");
    }
}
