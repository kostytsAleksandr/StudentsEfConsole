using Dapper;
using Students.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data.Repositories
{
    public class StudentsDapperRepository : IStudentsRepository
    {
        private const string CONNECTION_STRING = "Data Source=.;Initial Catalog=Students;Integrated Security=True";

        public Student Create(Student model)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                var queryString = $"INSERT INTO Students(Name, LastName, Age) OUTPUT INSERTED.id VALUES(\'{model.Name}\','{model.LastName}\', '{model.Age}\')";

                var insertedId = connection.ExecuteScalar(queryString);
                var insertedIdInt = Convert.ToInt32(insertedId);
                model.Id = insertedIdInt;

                return model;
            }
        }

        public IEnumerable<Student> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                return connection.Query<Student>("SELECT * FROM Students");
            }
        }
    }
}
