using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System.Security.Cryptography.X509Certificates;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApiContex _context;
        public CategoriesController(ApiContex contex)
        {
            _context = contex;
        }
        [HttpGet]
        public IActionResult CategoryList() 
        {
            var values = _context.Categories.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok("Kategori ekleme işlemi başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id) 
        {
            var value = _context.Categories.Find(id);
            _context.Categories.Remove(value);  
            _context.SaveChanges();
            return Ok("Kategori silme işlemi başarılı.");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id) 
        {
            var value = _context.Categories.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UptadeCategory (Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok("Kategori güncelleme başarılı");
        }

    }
}
