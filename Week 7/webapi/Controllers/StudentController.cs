using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Database;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllProducts()
        {
            var result = _dbContext.Student.ToList();
            return Ok(result);
        }

    }
}