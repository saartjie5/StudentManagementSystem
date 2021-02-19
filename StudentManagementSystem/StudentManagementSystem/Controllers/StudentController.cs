using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentService.GetAll());
        }

        [HttpPost]
        [Route("createStudent")]
        public IActionResult Post([FromBody]Student student)
        {

            return Ok(_studentService.CreateStudent(student));
        }


        [HttpGet]
        [Route("{studentId}/attending-lectures")]
        public IActionResult GetStudents(int studentId)
        {
            return Ok(_studentService.GetAttendingLectures(studentId));
        }

        [HttpPost]
        [Route("{studentId}/course/{courseId}/{grade}")]
        public IActionResult MarkGrade(int studentId, int courseId, string grade)
        { 
            return Ok(_studentService.GradeStudent(studentId, courseId, grade));
        }
        [HttpGet]
        [Route("{studentId}/average-grade")]
        public IActionResult Average(int studentId)
        {
            return Ok(_studentService.AverageGrade(studentId));
        }
    }
}
