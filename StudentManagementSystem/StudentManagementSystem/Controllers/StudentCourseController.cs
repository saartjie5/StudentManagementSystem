using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentCourseController : ControllerBase
    {
        private readonly IStudentCourseService _studentcourseService;

        public StudentCourseController(IStudentCourseService studentcourseService)
        {
            _studentcourseService = studentcourseService;

        }
        [HttpPost]
        [Route("createStudentCourse")]
        public IActionResult Post([FromBody] StudentCourse studentcourse)
        {

            return Ok(_studentcourseService.CreateStudentCourse(studentcourse));
        }
    }
}
