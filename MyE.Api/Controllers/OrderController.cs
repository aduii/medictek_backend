using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyE.Service;
using MyE.Entity;
namespace MyE.Api.Controllers
{
    
   [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService orderService;

        public OrderController (IOrderService orderService)
        {
            this.orderService = orderService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return Ok(
                orderService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            return Ok(
               orderService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Order  order)
        {
            return Ok(
            orderService.Save( order)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Order  order)
        {
            return Ok(
            orderService.Update( order)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            orderService.Delete(id)
            
            );
        }
    }



}
