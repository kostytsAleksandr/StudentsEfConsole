using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Domain.Models
{
    public class ProfessorsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int? DepartmentsModelId { get; set; }
        public DepartmentsModel Deparments { get; set; }
        public ICollection<StudentsModel> Students { get; set; }
    }
}
