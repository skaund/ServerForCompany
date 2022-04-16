using AppDiplomVasilenkoTepaykim.Data;
using AppDiplomVasilenkoTepaykim.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AppDiplomVasilenkoTepaykim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        public OrderDetailsController(AppDBContext db)
        {
            this.db = db;
        }
        private readonly AppDBContext db;

        [HttpGet]

        public IActionResult GetAll()
        {
            var orderDetails = db.OrderDetails.Include(s => s.Product).Include(s => s.Order).ToList();
            return Ok(orderDetails);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var orderDetails = db.OrderDetails.Include(s => s.Product).Include(s => s.Order).FirstOrDefault(s => s.OrderId == id);
            return Ok(orderDetails);
        }

        [HttpPost]

        public IActionResult Post(OrderDetails orderDetails)
        {

            if (orderDetails == null)
            {
                return BadRequest();
            }

            db.OrderDetails.Add(orderDetails);
            db.SaveChanges();
            return Ok(orderDetails);
        }

      

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var orderDetails = db.OrderDetails.Find(id);
            if (orderDetails == null)
            {
                return BadRequest();
            }
            else
            {

                db.OrderDetails.Remove(orderDetails);
                db.SaveChanges();
                return Ok();
            }
        }
    }
}
