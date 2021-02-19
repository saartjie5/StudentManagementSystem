using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services
{
    public class StudentCourseService : IStudentCourseService
    {
        private StudentManagementSystemContext dbContext;



        public StudentCourseService(StudentManagementSystemContext context)
        {

            dbContext = context;
        }
        public StudentCourse CreateStudentCourse(StudentCourse sc)
        {
            dbContext.Add(sc);
            dbContext.SaveChanges();
            return sc;
        }
    }
}
