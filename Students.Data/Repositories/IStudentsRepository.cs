using Students.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data.Repositories
{
    interface IStudentsRepository
    {
        IEnumerable<Student> GetAll();
        Student Create(Student model); 
    }
}
