using Microsoft.AspNetCore.Mvc;

namespace ProjectSchool_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : Controller
    {
        public ProfessorController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {         
            return Ok(); 
        }

        [HttpGet("{professorId}")]
        public IActionResult Get(int professorId)
        {         
            return Ok(); 
        }

        [HttpPost]
        public IActionResult Post()
        {         
            return Ok(); 
        }

        [HttpPut("{professorId}")]
        public IActionResult Put()
        {         
            return Ok(); 
        }

        [HttpDelete("{professorId}")]
        public IActionResult Delete()
        {         
            return Ok(); 
        }
    }
}