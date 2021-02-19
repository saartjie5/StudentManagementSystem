using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagementSystem.Models
{
    public partial class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public Lecture()
        {

        }
    }
}
