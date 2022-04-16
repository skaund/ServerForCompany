using AppDiplomVasilenkoTepaykim.Data;
using AppDiplomVasilenkoTepaykim.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AppDiplomVasilenkoTepaykim.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        public SuppliersController(AppDBContext db)
        {
            this.db = db;
        }
        private readonly AppDBContext db;

        [HttpGet]

        public IActionResult GetAll()
        {
            var supplier = db.Suppliers.Include(s => s.RequisitesCompany).Include(s => s.LocationCompanys).ToList();
            return Ok(supplier);
        }



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var supplier = db.Suppliers.Include(s => s.RequisitesCompany).Include(s => s.LocationCompanys).FirstOrDefault(s => s.Id == id);
            return Ok(supplier);
        }

        [HttpPost]

        public IActionResult Post(Supplier supplier1)
        {
            if (supplier1 == null)
            {
                return BadRequest();
            }
            db.RequisitesCompanys.Add(supplier1.RequisitesCompany);
            db.LocationCompanys.Add(supplier1.LocationCompanys);
            db.Suppliers.Add(supplier1);
            db.SaveChanges();
            return Ok(supplier1);
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, Supplier supplier1)
        {
            var supplier = db.Suppliers.Include(s => s.LocationCompanys).Include(s => s.RequisitesCompany).FirstOrDefault(s => s.Id == id);
            if (supplier == null)
            {
                return BadRequest();
            }
            else
            {
                supplier.NameSuppliers = supplier1.NameSuppliers;
                supplier.OwnerCompany = supplier1.OwnerCompany;



                var locationCompanys = db.LocationCompanys.FirstOrDefault(s => s.Id == supplier.CompanyLocationId);

                locationCompanys.Street = supplier1.LocationCompanys.Street;
                locationCompanys.HouseNumber = supplier1.LocationCompanys.HouseNumber;
                locationCompanys.Region = supplier1.LocationCompanys.Region;
                locationCompanys.Country = supplier1.LocationCompanys.Country;
                locationCompanys.ZipCode = supplier1.LocationCompanys.ZipCode;



                var requisitesCompany = db.RequisitesCompany.FirstOrDefault(s => s.Id == supplier.RequisitesId);

                requisitesCompany.NumberPhone = supplier1.RequisitesCompany.NumberPhone;
                requisitesCompany.Email = supplier1.RequisitesCompany.Email;
                requisitesCompany.KPP = supplier1.RequisitesCompany.KPP;
                requisitesCompany.LegalInn = supplier1.RequisitesCompany.LegalInn;
                requisitesCompany.PhysicalInn = supplier1.RequisitesCompany.PhysicalInn;





                db.RequisitesCompany.Update(requisitesCompany);
                db.LocationCompanys.Update(locationCompanys);

                db.Suppliers.Update(supplier);

                db.SaveChanges();
                return Ok();

            }
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var supplier = db.Suppliers.Find(id);
            if (supplier == null)
            {
                return BadRequest();
            }
            else
            {
                supplier = db.Suppliers.Include(s => s.RequisitesCompany).Include(s => s.LocationCompanys).FirstOrDefault(s => s.Id == id);
                db.Suppliers.Remove(supplier);
                db.SaveChanges();
                return Ok();
            }
        }
    }
}