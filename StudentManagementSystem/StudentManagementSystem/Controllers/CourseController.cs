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
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;

        }
     
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_courseService.GetAll());
        }

        [HttpPost]
        [Route("createCourse")]
        public IActionResult Post([FromBody]Course course)
        {

            return Ok(_courseService.CreateCourse(course));
        }
    }
}
