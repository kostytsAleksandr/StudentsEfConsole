using Students.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data.Repositories
{
    public class StudentsAdoNetRepository : IStudentsRepository
    {
        private const string CONNECTION_STRING = "Data Source=.;Initial Catalog=Students;Integrated Security=True";

        public Student Create(Student model)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                var queryString = "INSERT INTO Students(Name,LastName, Age) OUTPUT INSERTED.id VALUES(@Name,@LastName,@Age)";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@Name", model.Name);
                command.Parameters.AddWithValue("@LastName", model.LastName);
                command.Parameters.AddWithValue("@Age", model.Age);

                connection.Open();

                var studenId = command.ExecuteScalar();

                var studentIdInt = Convert.ToInt32(studenId);
                model.Id = studentIdInt;

                return model;
            }
        }

        public IEnumerable<Student> GetAll()
        {
            {
                var result = new List<Student>();

                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    var queryString = "SELECT * FROM Students";
                    SqlCommand command = new SqlCommand(queryString, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        result.Add(new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Age = reader.GetInt32(3),
                        });
                    }
                    reader.Close();

                    return result;
                }
            }
        }
    }
}
