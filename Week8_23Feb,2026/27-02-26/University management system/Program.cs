using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Input;

namespace University_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString =
                                        "Server=Gangotri\\SQLEXPRESS;" +
                                        "Database=UniversityDB;" +
                                        "Integrated Security=True;" +
                                        "TrustServerCertificate=True;";
                GetAllStudents(connectionString);

                InsertIntoStudentWithDeptID(
                    connectionString,
                    "Aarchi",
                    "Soorma",
                    "aarchi@gmail.com",
                    "Computer Science"
                );

                UpdateStudentWithDept(
                    connectionString,
                    2,
                    "Diksha",
                    "Tandan",
                    "diksha@gmail.com",
                    1
                );

                DeleteStudent(connectionString, 2);
            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.WriteLine();
        }
        

        static void InsertIntoStudentWithDeptID(
            string connectionString, string FirstName, string LastName, string Email, string DeptName)
        {
            Console.WriteLine("InsertIntoStudentWithDeptID Stored Procedure Called");

            using(SqlConnection conn = new SqlConnection( connectionString))
            {
                SqlCommand command = new SqlCommand("InsertIntoStudentWithDeptID", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@DeptName", DeptName);

                conn.Open();

                command.ExecuteNonQuery();
                conn.Close();

                Console.WriteLine("Student and DeptName created successfully.\n");
            }
        }

        static void UpdateStudentWithDept(
            string connectionString, int studentId, string FirstName, string LastName, String Email, int DeptId)
        {
            Console.WriteLine("UpdateStudentWithDept Stored Procedure Called");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateStudentWithDeptId", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@DeptId", DeptId);
                conn.Open();

                cmd.ExecuteNonQuery();
                conn.Close();

                Console.WriteLine("Student and DeptName Updated successfully.\n");
            }
        }
        static void GetAllStudents(string connectionString)
        {
            Console.WriteLine("GEt all Students");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllStudents", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"FirstName: {reader["FirstName"]}, " +
                        $"LastName: {reader["LastName"]}, " +
                        $"Email: {reader["Email"]}"
                    ); 
                    Console.WriteLine();
                }

                reader.Close();
                conn.Close();
            }
        }

        static void DeleteStudent(string connectionString, int studentId)
        {
            Console.WriteLine("DeleteStudent Stored Procedure Called");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentId", studentId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Student deleted successfully");
                else
                    Console.WriteLine("Student not found");
            }
        }
    }
}
