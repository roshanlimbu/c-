using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConsoleWithDbCrud
{
    public class DataAccess
    {
        private const string conString = "Data Source=localhost; Initial Catalog=TestDb; Integrated Security=SSPI";
        private SqlConnection con;
        private SqlCommand cmd;

        public DataAccess()
        {
            con = new SqlConnection();
            con.ConnectionString = conString;
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public bool AddStudent(Student s)
        {
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Student (Id, Name, Address, Gender, DoB) VALUES (@Id, @Name, @Address, @Gender, @DoB)";
                cmd.Parameters.AddWithValue("@Id", s.Id);
                cmd.Parameters.AddWithValue("@Name", s.Name);
                cmd.Parameters.AddWithValue("@Address", s.Address);
                cmd.Parameters.AddWithValue("@Gender", s.Gender);
                cmd.Parameters.AddWithValue("@DoB", s.DoB);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Student> GetStudentList()
        {
            List<Student> list = new List<Student>();
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM Student";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student student = new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            Gender = reader.GetString(3),
                            DoB = reader.GetDateTime(4)
                        };
                        list.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return list;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
    }
}
