using Azure.Core;
using BarangaySystem.Domain.Entities;
using BarangaySystem.Infrastructure.Persistance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarangaySystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PositionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Positions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Positions>>> GetPositions()
        {
            return await _context.Positions.ToListAsync();
        }

        // GET: api/Positions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Positions>> GetPositions(int id)
        {
            var positions = await _context.Positions.FindAsync(id);

            if (positions == null)
            {
                return NotFound();
            }

            return positions;
        }

        // PUT: api/Positions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPositions(int id, Positions positions)
        {
            var query = _context.Positions.Where(m => m.Id == id).FirstOrDefault();

            if (query == null)
            {

                return NotFound(new { message = "Data not found" });
            }

            query.PositionName = positions.PositionName;
            query.updatedAt = DateTime.Now;

            _context.SaveChanges();
           return Ok(new { message = "Sucessfully Updated" }); ;
        }

        // POST: api/Positions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Positions>> PostPositions(Positions positions)
        {
            _context.Positions.Add(positions);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Sucessfully Created" }); ;
        }

        // DELETE: api/Positions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePositions(int id)
        {
            var positions = await _context.Positions.FindAsync(id);
            if (positions == null)
            {
                return NotFound();
            }

            _context.Positions.Remove(positions);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Sucessfully Delete" });
        }

        private bool PositionsExists(int id)
        {
            return _context.Positions.Any(e => e.Id == id);
        }
    }
}
