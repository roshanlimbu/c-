using System;

public class Gender
{
  private string gender;
  private string strong;

  public string GenderProperty
  {
    get
    {
      return gender;
    }
    set
    {
      strong = value;
      if (value == "m")
      {
        Console.WriteLine("You are strong.");
      }
      else
      {
        Console.WriteLine("You are weak.");
      }
      gender = value;
    }
  }
}

public class Program
{
  public static void Main(string[] args)
  {
    Gender p = new Gender();
    Console.WriteLine("Enter your gender: ");
    string text = Console.ReadLine();
    p.GenderProperty = text;
  }
}
