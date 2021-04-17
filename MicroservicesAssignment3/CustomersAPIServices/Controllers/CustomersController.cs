using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomersAPIServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]  
        public IEnumerable<string> Get()  
        {  
            return new[] { "Saloni Jain", "Dummy Text" };  
        }  
  
        [HttpGet("{id}")]  
        public string Get(int id)  
        {  
            return $"Saloni Jain - {id}";  
        }
    }
}
