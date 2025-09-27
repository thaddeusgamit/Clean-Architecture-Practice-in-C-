using Azure.Core;
using BarangaySystem.Domain.Entities;
using BarangaySystem.Infrastructure.Persistance;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BarangaySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {

        private readonly AppDbContext _context;

        public ReportsController(AppDbContext context)
        { 
            _context = context;
        
        }

        // GET: api/<ReportsController>
        [HttpGet]
        public IActionResult GetAllReports()
        {
            var reports = _context.Reports.ToList();
            return Ok(reports);
        }

        // GET api/<ReportsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var query = _context.Reports.Where(m => m.Id == id).FirstOrDefault();

            if (query == null)
            {
                return NotFound();
            }

            return Ok(query);



        }

        // POST api/<ReportsController>
        [HttpPost]
        public IActionResult CreateReports (Reports request)
        {
            _context.Reports.Add(request);
            _context.SaveChanges();
            return Ok(request);

        }

        // PUT api/<ReportsController>/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, Reports request)
        {
            var query = _context.Reports.Where(m => m.Id == id).FirstOrDefault();

            if (query == null) {

                return NotFound(new { message = "Report not found" });
            }

            query.Type = request.Type;
            query.updatedAt = DateTime.Now;

            _context.SaveChanges();
            return Ok(request);
           
        }

        // DELETE api/<ReportsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var query = _context.Reports.Where(m => m.Id == id).FirstOrDefault();

            if (query == null)
            {

                return NotFound(new { message = "Report not found" });
            }

            _context.Remove(query);
            _context.SaveChanges();

            return Ok(new { message = "Sucessfully Delete" });
        }
    }
}
