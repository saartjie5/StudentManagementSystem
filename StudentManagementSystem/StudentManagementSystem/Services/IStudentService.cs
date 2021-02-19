using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();

        Student CreateStudent(Student student);
        List<Lecture> GetAttendingLectures(int studentId);
        StudentCourse GradeStudent(int studentId, int courseId, string grade);
        float AverageGrade(int StudentId);
    }

}
