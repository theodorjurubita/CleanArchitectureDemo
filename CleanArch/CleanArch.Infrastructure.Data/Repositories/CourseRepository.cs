using System.Collections.Generic;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infrastructure.Data.Context;

namespace CleanArch.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _universityDbContext;

        public CourseRepository(UniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _universityDbContext.Courses;
        }

        public void Add(Course course)
        {
            _universityDbContext.Add(course);
            _universityDbContext.SaveChanges();
        }
    }
}
