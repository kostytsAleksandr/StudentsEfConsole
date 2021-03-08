using Students.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Data.Repositories
{
    class StudentsEfRepository : IStudentsRepository
    {
        public Student Create(Student model)
        {
            using (var ctx = new StudentsContext("Default"))
            {
                ctx.Students.Add(model);
                ctx.SaveChanges();
            };

            return model;
        }

        public IEnumerable<Student> GetAll()
        {
            using (var ctx = new StudentsContext("Default"))
            {
                return ctx.Students.ToList();
            };
        }
    }
}
