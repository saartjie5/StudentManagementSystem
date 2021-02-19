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
    public class LectureController : ControllerBase
    {
        private readonly ILectureService _lectureService;

        public LectureController(ILectureService lectureService)
        {
            _lectureService = lectureService;

        }

        [HttpGet]
        [Route("{lectureId}/attending-students")]
        public IActionResult Get(int lectureId)
        {

            return Ok(_lectureService.GetAttendingStudents(lectureId));
        }

        [HttpPost]
        [Route("createLecture")]
        public IActionResult Post([FromBody]Lecture lecture)
        {

            return Ok(_lectureService.CreateLecture(lecture));
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(_lectureService.GetAll());
        }


    }
}
