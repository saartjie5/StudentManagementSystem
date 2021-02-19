using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services
{
    public interface ILectureService
    {
        List<Student> GetAttendingStudents(int lectureId);
        Lecture CreateLecture(Lecture lecture);
        List<Lecture> GetAll();
    }
}
