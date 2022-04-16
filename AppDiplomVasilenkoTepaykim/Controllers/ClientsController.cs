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
    public class ClientsController : ControllerBase
    {
        public ClientsController(AppDBContext db)
        {
            this.db = db;
        }
        private readonly AppDBContext db;

        [HttpGet]

        public IActionResult GetAll()
        {
            var clients = db.Customers.Include(s => s.RequisitesClient).Include(s => s.LocationDelivery).ToList();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = db.Customers.Include(s => s.RequisitesClient).Include(s => s.LocationDelivery).FirstOrDefault(s => s.Id == id);
            return Ok(customer);
        }

        [HttpPost]

        public IActionResult Post(Customer customer)
        {

            if(customer == null)
            {
                return BadRequest();
            }
            db.RequisitesCompany.Add(customer.RequisitesClient);
            db.LocationDeliverys.Add(customer.LocationDelivery);
            db.Customers.Add(customer);
            db.SaveChanges();
            return Ok(customer);
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, Customer customer1)
        {
            var customer = db.Customers.Include(s => s.RequisitesClient).Include(s => s.LocationDelivery).FirstOrDefault(s => s.Id == id);
            if (customer == null)
            {
                return BadRequest();
            }
            else
            {
                customer.FirstName = customer1.FirstName;
                customer.LastName = customer1.LastName;

                

                var locationDelivery = db.LocationDeliverys.FirstOrDefault(s => s.Id == customer.CompanyLocationId);

                locationDelivery.Country = customer1.LocationDelivery.Country;
                locationDelivery.HouseNumber = customer1.LocationDelivery.HouseNumber;
                locationDelivery.Region = customer1.LocationDelivery.Region;
                locationDelivery.Street = customer1.LocationDelivery.Street;
                locationDelivery.ZipCode = customer1.LocationDelivery.ZipCode;

                var requisitesClient = db.RequisitesCompany.FirstOrDefault(s => s.Id == customer.RequisitesId);

                requisitesClient.NumberPhone = customer1.RequisitesClient.NumberPhone;
                requisitesClient.Email = customer1.RequisitesClient.Email;
                requisitesClient.LegalInn = customer1.RequisitesClient.LegalInn;
                requisitesClient.PhysicalInn = customer1.RequisitesClient.PhysicalInn;
                requisitesClient.KPP = customer1.RequisitesClient.KPP;
               


                db.RequisitesCompany.Update(requisitesClient);
                db.LocationDeliverys.Update(locationDelivery);

                db.Customers.Update(customer);

                db.SaveChanges();
                return Ok();
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
             var customer = db.Customers.Find(id);
            if (customer == null)
            {
                return BadRequest();
            }
            else
            {
                
                db.Customers.Remove(customer);
                db.SaveChanges();
                return Ok();
            }

        }

    }
}
