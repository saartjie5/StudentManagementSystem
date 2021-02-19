using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services 
{
    public class LectureService : ILectureService
    {
        private StudentManagementSystemContext dbContext;



        public LectureService(StudentManagementSystemContext context)
        {

            dbContext = context;
        }
        public List<Student> GetAttendingStudents(int lectureId) 
        {
            Lecture lecture = dbContext.Lectures.Where(x => x.Id == lectureId).FirstOrDefault();
            Course course = dbContext.Courses.Where(x => x.Id == lecture.CourseId).FirstOrDefault();
            List<StudentCourse> studentCourses = dbContext.StudentCourses.Where(x => x.CourseId == course.Id).ToList();
            List<Student> students = new List<Student>();
            foreach (var s in studentCourses)
            {
                students.Add(dbContext.Students.Where(x => x.Id == s.StudentId).FirstOrDefault());
            } 

            return students;
        }

        public Lecture CreateLecture(Lecture l)
        {
            dbContext.Lectures.Add(l);
            dbContext.SaveChanges();
            return l;
        }
        public List<Lecture> GetAll()
        {
            List<Lecture> lectures = new List<Lecture>();
            lectures = dbContext.Lectures.ToList();
            return lectures;
        }

    }
}
