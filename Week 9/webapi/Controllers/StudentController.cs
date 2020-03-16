using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Database;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        [Authorize]
        public ActionResult<List<Student>> GetAllStudents()
        {
           // var result = _dbContext.Student.ToList();
            return Ok(_studentService.GetAllStudents());
        }

    }
}