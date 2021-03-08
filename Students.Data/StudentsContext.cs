using Students.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data
{
    public class StudentsContext:DbContext
    {
        public StudentsContext() : base("Default")
        {
        }
        public StudentsContext(string connectionString) : base(connectionString)
        {
        }

        //public DbSet<Department> Departments { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
