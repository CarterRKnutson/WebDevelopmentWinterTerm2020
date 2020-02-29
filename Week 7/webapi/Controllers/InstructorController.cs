using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class InstructorController : ControllerBase
    {
        
        [HttpGet]
        public ActionResult<List<Instructor>> Get()
        {
            return Ok(getInstructors());
        }

         private List<Instructor> getInstructors()
        {
            return InMemory.Instructors;
        }  

    }
}