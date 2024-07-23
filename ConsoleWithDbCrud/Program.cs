namespace ConsoleWithDbCrud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Student s = new Student() { Id = 101, Name = "Rosahan", Address = "Birtnagar", Gender = true, DoB = new DateOnly(2002, 10, 24) };*/
            DataAccess DA = new DataAccess();
            /*if (DA.AddStudent(s))*/
            /*{*/
            /*    Console.WriteLine("Record Added.");*/
            /*}*/
            /*else*/
            /*{*/
            /*    System.Console.WriteLine("insertion failed");*/
            List<Student> list = DA.GetStudentList();
            Console.WriteLine("Name\tAddress\tGender\tDoB");
            foreach (Student s in list)
            {
                System.Console.WriteLine($"{s.Name}\t{s.Address}\t{s.Gender}\t{s.DoB}");

            }
            Console.ReadKey();
            /*DA.GetStudentList();*/


            /*}*/

        }
    }

}
