using Microsoft.AspNetCore.Mvc;
using Nugget2.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nugget2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return new [] { 
                new Event { Name = "Event A", Date = new DateTime(2023, 6, 1, 20, 0, 0)},
                new Event { Name = "Event B", Date = new DateTime(2023, 6, 2, 20, 0, 0)},
                new Event { Name = "Event C", Date = new DateTime(2023, 6, 3, 20, 0, 0)},
            };
        }
    }
}
