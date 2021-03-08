using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data.Models
{
    public class Professor
    {
        public Professor()
        {
            Students = new List<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

       // public int? DepartmentId { get; set; }
        //public Department Deparment { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
