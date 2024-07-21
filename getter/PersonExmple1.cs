namespace PropertiesExample{
  public claass Person {
    public string name; 
    public string address;
  }
  public class Program {
    public static void Main(string[] args){
      Person p = new Person();
      p.name = "Roshan";
      p.address = "Dharan";
      Console.WriteLine($"Hello {p.name}, you live in {p.address}");
      Console.ReadKey();
    }
  }
}
