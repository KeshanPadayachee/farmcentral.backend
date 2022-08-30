using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using com.farmcentral.be.Data;
using com.farmcentral.be.Models;

namespace com.farmcentral.be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmersController : ControllerBase
    {
        private readonly comfarmcentralbeContext _context;

        public FarmersController(comfarmcentralbeContext context)
        {
            _context = context;
        }

        // GET: api/Farmers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Farmer>>> GetFarmer()
        {
            return await _context.Farmer.ToListAsync();
        }

        // GET: api/Farmers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Farmer>> GetFarmer(string id)
        {
            var farmer = await _context.Farmer.FindAsync(id);

            if (farmer == null)
            {
                return NotFound();
            }

            return farmer;
        }

        // PUT: api/Farmers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFarmer(string id, Farmer farmer)
        {
            if (id != farmer.FarmerId)
            {
                return BadRequest();
            }

            _context.Entry(farmer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FarmerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Farmers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Farmer>> PostFarmer(Farmer farmer)
        {
            _context.Farmer.Add(farmer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FarmerExists(farmer.FarmerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFarmer", new { id = farmer.FarmerId }, farmer);
        }

        // DELETE: api/Farmers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFarmer(string id)
        {
            var farmer = await _context.Farmer.FindAsync(id);
            if (farmer == null)
            {
                return NotFound();
            }

            _context.Farmer.Remove(farmer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FarmerExists(string id)
        {
            return _context.Farmer.Any(e => e.FarmerId == id);
        }
    }
}
