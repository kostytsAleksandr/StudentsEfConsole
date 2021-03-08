using Students.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.Data.Repositories;
using Students.Data.Models;

namespace Students.Domain.Services.Intefaces
{
    public class StudentsService : IStudentsService
    {
        private readonly IStudentsRepository _studentsRepository;

        public StudentsService(IStudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }
        public StudentsModel Create(StudentsModel model)
        {
            var student = new Student
            {
                Name = model.Name,
                LastName = model.LastName,
                Age=model.Age
            };

            _studentsRepository.Create(student);

            model.Id = student.Id;

            return model;
        }

        public IEnumerable<StudentsModel> GetAll()
        {
            var students = _studentsRepository.GetAll();
            // Create BL instances from DAL instances
            var result = new List<StudentsModel>();

            foreach (var student in students)
            {
                result.Add(new StudentsModel
                {
                    Id = student.Id,
                    LastName = student.LastName,
                    Name = student.Name
                });
            }
            return result;
        }
    }
}
