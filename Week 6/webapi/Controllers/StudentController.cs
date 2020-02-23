using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Database;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return Ok(getStudents());
        }

         private List<Student> getStudents()
        {
            return InMemory.Students;
        }  

    }
}