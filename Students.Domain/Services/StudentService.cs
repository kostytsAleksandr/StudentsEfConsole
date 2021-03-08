using Students.Domain.Models;
using Students.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Domain.Services.Intefaces
{
    class StudentService : IStudentService
    {
        private readonly IStudentSRepository _studentsRepository;

        public AnimalService(IAnimalsRepository animalsRepository)
        {
            _animalsRepository = animalsRepository;
        }
        public StudentsModel Create(StudentsModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentsModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
