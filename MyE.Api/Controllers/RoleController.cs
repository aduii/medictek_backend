using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyE.Service;
using MyE.Entity;
namespace MyE.Api.Controllers
{
    
   [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private IRoleService roleService;

        public RoleController (IRoleService roleService)
        {
            this.roleService = roleService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Role>> Get()
        {
            return Ok(
                roleService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Role> Get(int id)
        {
            return Ok(
               roleService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Role  role)
        {
            return Ok(
            roleService.Save( role)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Role  role)
        {
            return Ok(
            roleService.Update( role)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            roleService.Delete(id)
            
            );
        }
    }



}
