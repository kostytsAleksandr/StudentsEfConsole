using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Domain.Models
{
    class DepartmentsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<StudentsModel> Students { get; set; }
        public ICollection<ProfessorsModel> Professors { get; set; }
    }
}
