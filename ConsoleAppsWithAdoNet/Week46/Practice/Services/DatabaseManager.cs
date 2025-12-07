using Practice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Services
{
    public class DatabaseManager
    {
        private readonly string _connectionString;
        public DatabaseManager(string connectionString) 
        {
            _connectionString = connectionString;
        }


        public int CreateStudent(Student student)
        {

            try
            {
                using var connection = new SqlConnection(_connectionString);

                connection.Open();


                const string sql = @"
        INSERT INTO Students ( FirstName, LastName, Age, Grade, CreatedAt)
        VALUES( @FirstName, @LastName, @Age, @Grade, @CreatedAt);
        SELECT SCOPE_IDENTITY();
    ";

        //        const string sql = @"
        //INSERT INTO Customers (Name, Email, CreatedAt) 
        //VALUES (@Name, @Email, @CreatedAt);
        //SELECT SCOPE_IDENTITY();

                using var command = new SqlCommand(sql, connection);

                
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Grade", 0);
                command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);


                var result = command.ExecuteScalar();

                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public List<Student> GetAllStudents() 
        {
            using var connection =  new SqlConnection(_connectionString);

            connection.Open();

            const string sql = "SELECT Id, FirstName, LastName, Age, Grade, CreatedAT FROM Students ORDER BY ID";

            using var command = new SqlCommand(sql, connection);


            var students = new List<Student>();

            using var reader = command.ExecuteReader();


            while (reader.Read())
            {
                students.Add(new Student
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Age = reader.GetInt32(3),
                    Grade = reader.GetInt32(4),
                    CreatedAt = reader.GetDateTime(5)
                });

            }

            return students;

        }



        public bool UpdateStudent(Student student)
        {
            using var connection = new SqlConnection(_connectionString);

            connection.Open();

            const string sql = @"
        UPDATE Students
        SET FirstName = @FirstName, LastName = @LastName
        WHERE Id =  @Id
    ";

            using var command =  new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", student.Id);
            command.Parameters.AddWithValue("@FirstName", student.FirstName);
            command.Parameters.AddWithValue("@LastName", student.LastName);

            int affectedRows = command.ExecuteNonQuery();


            return affectedRows > 0;
        }


        public bool DeleteStudent(int Id)
        {
            using var connection = new SqlConnection(_connectionString);

            connection.Open();

            const string sql = "DELETE FROM Students WHERE Id = @Id;";

            using var command = new SqlCommand(sql, connection);


            command.Parameters.AddWithValue("@Id", Id);


            int affectedRows = command.ExecuteNonQuery();


            return affectedRows > 0;

        }
    }
}
