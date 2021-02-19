using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagementSystem.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string IndexNumber { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
