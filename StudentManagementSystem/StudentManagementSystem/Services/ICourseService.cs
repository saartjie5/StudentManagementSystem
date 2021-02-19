using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course CreateCourse(Course course);
    }
}
