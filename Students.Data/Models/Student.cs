using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data.Models
{
    public class Student
    {
        public Student()
        {
            Professors = new List<Professor>();
           // Departments = new List<Department>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public ICollection<Professor> Professors { get; set; }
       // public ICollection<Department> Departments { get; set; }
    }
}
