using CleanArch.Data.Context;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Data.Repository
{
   public class CourseRepository : ICourseRepository
   {
      private readonly UniversityDBContext _dataContext;

      public CourseRepository(UniversityDBContext dataContext)
      {
         _dataContext = dataContext;
      }
      public IEnumerable<Course> GetCourses()
      {
         return _dataContext.Courses;
      }
   }
}
