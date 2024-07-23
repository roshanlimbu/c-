using System;

public class Program
{
    public class Person
    {
        private string address;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 1)
                {
                    name = value;
                }
                else
                {
                    name = "No name";
                }
            }

        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (value.Equals("Itahari") || value.Equals("Dharan") || value.Equals("Biratnagar"))
                {
                    address = value;
                }
                else
                {
                    Console.WriteLine("Invalid address");
                    address = "Itahari";
                }
            }
        }

        public int Id { get; set; }


    }

    public static void Main(string[] args)
    {
        Person p = new Person();
        p.Name = "Roshan";
        p.Address = "Damak";
        p.Id = 101;
        Console.WriteLine($"Hello {p.Name} lives in {p.Address}. Your id is {p.Id}");
        Console.ReadKey();
    }
}
