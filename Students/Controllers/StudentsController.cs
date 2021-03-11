using Students.Domain.Services.Intefaces;
using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Controllers
{
    //public class StudentsController
    //{
    //    private readonly IStudentsService _studentsService;

    //    public StudentsController(IStudentsService studentsService)
    //    {
    //        _studentsService = studentsService;
    //    }

    //    public IEnumerable<StudentsViewModel> GetAll()
    //    {
    //        var animals = _studentsService.GetAll();

    //        var result = new List<StudentsViewModel>();

    //        foreach (var animal in animals)
    //        {
    //            result.Add(new StudentsViewModel
    //            {
    //                Id = animal.Id,
    //                Name = animal.Name,
    //                Breed = animal.Breed.Name,
    //                Type = "Unknown"
    //            });
    //        }

    //        return result;
    //    }

    //    public StudentsViewModel Create(StudentsPostModel model)
    //    {
    //        var animalModel = new StudentsPostModel
    //        {
    //            Name = model.Name,
    //            BreedId = model.BreedId
    //        };

    //        var createResult = _studentsService.Create(animalModel);

    //        var result = new StudentsViewModel
    //        {
    //            Id = createResult.Id,
    //            Name = createResult.Name,
    //            Breed = "Unknown"
    //        };

    //        return result;
    //    }
    //}
}
