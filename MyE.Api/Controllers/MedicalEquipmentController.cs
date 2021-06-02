using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyE.Service;
using MyE.Entity;
namespace MyE.Api.Controllers
{
    
   [Route("api/[controller]")]
    [ApiController]
    public class MedicalEquipmentController : ControllerBase
    {
        private IMedicalEquipmentService medicalEquipmentService;

        public MedicalEquipmentController (IMedicalEquipmentService medicalEquipmentService)
        {
            this.medicalEquipmentService = medicalEquipmentService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<MedicalEquipment>> Get()
        {
            return Ok(
                medicalEquipmentService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<MedicalEquipment> Get(int id)
        {
            return Ok(
               medicalEquipmentService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] MedicalEquipment  medicalEquipment)
        {
            return Ok(
            medicalEquipmentService.Save( medicalEquipment)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] MedicalEquipment  medicalEquipment)
        {
            return Ok(
            medicalEquipmentService.Update( medicalEquipment)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            medicalEquipmentService.Delete(id)
            
            );
        }
    }



}
