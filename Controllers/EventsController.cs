﻿using Microsoft.AspNetCore.Mvc;
using Nugget2.Contract;
using Nugget2.Model;
using Nugget2.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nugget2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService service;

        public EventsController(IEventService service)
        {
            this.service = service;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return service.Get();
        }
    }
}
