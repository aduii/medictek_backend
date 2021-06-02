using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyE.Service;
using MyE.Entity;
//revisar
namespace MyE.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FinalReportController : ControllerBase
    {
        private IFinalReportService finalReportService;

        public FinalReportController(IFinalReportService finalReportService)
        {
            this.finalReportService = finalReportService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<FinalReport>> Get()
        {
            return Ok(
                finalReportService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<FinalReport> Get(int id)
        {
            return Ok(
               finalReportService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] FinalReport finalReport)
        {
            return Ok(
            finalReportService.Save(finalReport)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] FinalReport finalReport)
        {
            return Ok(
            finalReportService.Update(finalReport)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            finalReportService.Delete(id)
            
            );
        }
    }
}