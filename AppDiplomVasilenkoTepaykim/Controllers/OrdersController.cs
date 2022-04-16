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
    public class OrdersController : ControllerBase
    {
        public OrdersController(AppDBContext db)
        {
            this.db = db;
        }
        private readonly AppDBContext db;

        [HttpGet]

        public IActionResult GetAll()
        {
            var orders = db.Order.Include(s => s.Customer).Include(s => s.LocationDelivery).ToList();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = db.Order.Include(s => s.Customer).Include(s => s.LocationDelivery).FirstOrDefault(s => s.Id == id);
            return Ok(order);
        }

        [HttpPost]

        public IActionResult Post(Order order)
        {

            if (order == null)
            {
                return BadRequest();
            }

            db.Order.Add(order);
            db.SaveChanges();
            return Ok(order);
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, Order order1)
        {
            var order = db.Order.Include(s => s.Customer).Include(s => s.LocationDelivery).FirstOrDefault(s => s.Id == id);
            if (order == null)
            {
                return BadRequest();
            }
            else
            {
                order.LocationDeliveryId = order1.LocationDeliveryId;
                order.StaffId = order1.StaffId;
                order.CustomerId = order1.CustomerId;
                order.Date = order1.Date;
                order.TotalAmount = order1.TotalAmount;

                db.Order.Update(order);

                db.SaveChanges();
                return Ok();
            }
    
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var order = db.Order.Find(id);
            if (order == null)
            {
                return BadRequest();
            }
            else
            {

                db.Order.Remove(order);
                db.SaveChanges();
                return Ok();
            }

        }
    }
}
