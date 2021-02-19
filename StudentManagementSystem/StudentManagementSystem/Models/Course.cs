using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagementSystem.Models
{
    public partial class Course
    {
        public Course()
        {
            Lectures = new HashSet<Lecture>();
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Lecture> Lectures { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
