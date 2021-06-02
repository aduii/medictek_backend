using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyE.Service;
using MyE.Entity;
namespace MyE.Api.Controllers
{
    
   [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private IScheduleService scheduleService;

        public ScheduleController (IScheduleService scheduleService)
        {
            this.scheduleService = scheduleService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Schedule>> Get()
        {
            return Ok(
                scheduleService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Schedule> Get(int id)
        {
            return Ok(
               scheduleService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Schedule  schedule)
        {
            return Ok(
            scheduleService.Save( schedule)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Schedule  schedule)
        {
            return Ok(
            scheduleService.Update( schedule)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            scheduleService.Delete(id)
            
            );
        }
    }



}
