using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyE.Service;
using MyE.Entity;
namespace MyE.Api.Controllers
{
    
   [Route("api/[controller]")]
    [ApiController]
    public class MachineReviewController : ControllerBase
    {
        private IMachineReviewService machineReviewService;

        public MachineReviewController (IMachineReviewService machineReviewService)
        {
            this.machineReviewService = machineReviewService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<MachineReview>> Get()
        {
            return Ok(
                machineReviewService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<MachineReview> Get(int id)
        {
            return Ok(
               machineReviewService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] MachineReview  machineReview)
        {
            return Ok(
            machineReviewService.Save( machineReview)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] MachineReview  machineReview)
        {
            return Ok(
            machineReviewService.Update( machineReview)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            machineReviewService.Delete(id)
            
            );
        }
    }



}