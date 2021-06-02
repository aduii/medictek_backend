using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyE.Service;
using MyE.Entity;
namespace MyE.Api.Controllers
{
    
   [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController (IUserService userService)
        {
            this.userService = userService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(
                userService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return Ok(
               userService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] User  user)
        {
            return Ok(
            userService.Save( user)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] User  user)
        {
            return Ok(
            userService.Update( user)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            userService.Delete(id)
            
            );
        }
    }



}
