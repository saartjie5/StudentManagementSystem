using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services
{
    public class CourseService : ICourseService
    {
        private StudentManagementSystemContext dbContext;



        public CourseService(StudentManagementSystemContext context)
        {

            dbContext = context;
        }
        public List<Course> GetAll()
        {
            List<Course> courses = new List<Course>();
            courses = dbContext.Courses.ToList();
            return courses;
        }
        public Course CreateCourse(Course c)
        {
            dbContext.Courses.Add(c);
            dbContext.SaveChanges();
            return c;
        }
    }
}
