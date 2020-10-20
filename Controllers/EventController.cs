using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UpmeetProject.Models;
using UpmeetProject.Services;


namespace UpmeetProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private IDAL dal;
        public EventController(IDAL dal)
        {
            this.dal = dal;
        }

        [HttpGet]
        public IEnumerable<Event> GetEventList()
        {
            return dal.GetEventList();
        }
        [HttpGet("{id}")]
        public Event GetEvent(long id )
        {
            return dal.GetEvent(id);
        }



    }
}
