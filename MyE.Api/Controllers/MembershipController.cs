using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyE.Service;
using MyE.Entity;
namespace MyE.Api.Controllers
{
    
   [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        private IMembershipService membershipService;

        public MembershipController (IMembershipService membershipService)
        {
            this.membershipService = membershipService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Membership>> Get()
        {
            return Ok(
                membershipService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Membership> Get(int id)
        {
            return Ok(
               membershipService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Membership  membership)
        {
            return Ok(
            membershipService.Save( membership)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Membership  membership)
        {
            return Ok(
            membershipService.Update( membership)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            membershipService.Delete(id)
            
            );
        }
    }



}

