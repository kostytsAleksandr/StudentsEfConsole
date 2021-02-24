using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data.Models
{
    public class Deparment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Professor> Professors { get; set; }
    }
}
