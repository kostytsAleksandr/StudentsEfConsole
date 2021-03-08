using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Domain.Models
{
    class StudentsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public ICollection<ProfessorsModel> Professors { get; set; }
        // public ICollection<Department> Departments { get; set; }
    }
}
