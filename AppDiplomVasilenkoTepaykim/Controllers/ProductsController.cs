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
    public class ProductsController : ControllerBase
    {
        public ProductsController(AppDBContext db)
        {
            this.db = db;
        }
        private readonly AppDBContext db;

        [HttpGet]

        public IActionResult GetAll()
        {
            var products = db.Product.Include(s => s.Unit).Include(s => s.Category).ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var products = db.Product.Include(s => s.Unit).Include(s => s.Category).FirstOrDefault(s => s.Id == id);
            return Ok(products);
        }

        [HttpPost]

        public IActionResult Post(Product products)
        {

            if (products == null)
            {
                return BadRequest();
            }

            db.Product.Add(products);
            db.SaveChanges();
            return Ok(products);
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, Product product)
        {
            var products = db.Product.Include(s => s.Unit).Include(s => s.Category).FirstOrDefault(s => s.Id == id);
            if (products == null)
            {
                return BadRequest();
            }
            else
            {
                products.NameProduct = product.NameProduct;
                products.ProductionDate = product.ProductionDate;
                products.CategoryId = product.CategoryId;
                products.UnitId = product.UnitId;
                products.ExpirationDate = product.ExpirationDate;
                products.Quantity = product.Quantity;
                products.SupplierId = product.SupplierId;


                db.Product.Update(products);

                db.SaveChanges();
                return Ok();
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var products = db.Product.Find(id);
            if (products == null)
            {
                return BadRequest();
            }
            else
            {

                db.Product.Remove(products);
                db.SaveChanges();
                return Ok();
            }

        }
    }
}
