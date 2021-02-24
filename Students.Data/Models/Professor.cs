using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int DepartmentId { get; set; }
        public Deparment Deparment { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
