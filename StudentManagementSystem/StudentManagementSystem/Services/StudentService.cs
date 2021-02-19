using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Services
{
    public class StudentService : IStudentService
    {
        private StudentManagementSystemContext dbContext;



        public StudentService(StudentManagementSystemContext context)
        {

            dbContext = context;
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            students = dbContext.Students.ToList();
            return students;
        }

        public Student CreateStudent(Student s) 
        {
            dbContext.Students.Add(s);
            dbContext.SaveChanges();
            return s;
        }
        public List<Lecture> GetAttendingLectures(int studentId)
        {
            Student student = dbContext.Students.Where(x => x.Id == studentId).FirstOrDefault();
            List<StudentCourse> studentCourses = dbContext.StudentCourses.Where(x => x.StudentId == student.Id).ToList();
            List<Course> courses = new List<Course>();
            foreach(var s in studentCourses)
            {
                courses.Add(dbContext.Courses.Where(x => x.Id == s.CourseId).FirstOrDefault());

            }
            List<Lecture> lectures = new List<Lecture>();
            foreach(var s in courses)
            {
                lectures.AddRange(dbContext.Lectures.Where(x => x.CourseId == s.Id).ToList());
            }

            return lectures;     
        }

        public StudentCourse GradeStudent(int studentId, int courseId, string grade)
        {
            StudentCourse studentCourse = dbContext.StudentCourses.Where(x => x.StudentId == studentId && x.CourseId == courseId).FirstOrDefault();
            studentCourse.Grade = grade;
            dbContext.SaveChanges();
            return studentCourse;
        }

        public float AverageGrade(int studentId)
        {
            float averageGrade=0;
            int counter = 0;
            List<StudentCourse> studentCourses = dbContext.StudentCourses.Where(x => x.StudentId == studentId && x.Grade != "5").ToList();
            foreach(var s in studentCourses)
            {
                counter++;
                int grade = int.Parse(s.Grade);
                averageGrade += grade;
            }
            averageGrade /= counter;
           
            return averageGrade;
        }

    }
}
