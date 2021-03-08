using Students.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Domain.Services.Intefaces
{
    interface IStudentService
    {
        IEnumerable<StudentsModel> GetAll();
        StudentsModel Create(StudentsModel model);
    }
}
