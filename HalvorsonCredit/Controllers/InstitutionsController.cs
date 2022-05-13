using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HalvorsonCredit.Data;
using HalvorsonCredit.Models;
using Microsoft.AspNetCore.Authorization;


namespace HalvorsonCredit.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionsController : ControllerBase
    {
        private readonly HalvorsoncreditContext _context;

        private readonly JwtAuthenticationManager authManager;

        public InstitutionsController(HalvorsoncreditContext context, JwtAuthenticationManager authManager)
        {
            _context = context;
            this.authManager = authManager;
        }

        // GET: api/Institutions
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Institution>>> GetInstitutions()
        {
          if (_context.Institutions == null)
          {
              return NotFound();
          }
            return await _context.Institutions.ToListAsync();
        }

        // GET: api/Institutions/5
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Institution>> GetInstitution(int id)
        {
          if (_context.Institutions == null)
          {
              return NotFound();
          }
            var institution = await _context.Institutions.FindAsync(id);

            if (institution == null)
            {
                return NotFound();
            }

            return institution;
        }

        // PUT: api/Institutions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstitution(int id, Institution institution)
        {
            if (id != institution.InstitutionId)
            {
                return BadRequest();
            }

            _context.Entry(institution).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstitutionExists(id))
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

        // POST: api/Institutions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Institution>> PostInstitution(Institution institution)
        {
          if (_context.Institutions == null)
          {
              return Problem("Entity set 'HalvorsoncreditContext.Institutions'  is null.");
          }
            _context.Institutions.Add(institution);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstitution", new { id = institution.InstitutionId }, institution);
        }

        // DELETE: api/Institutions/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstitution(int id)
        {
            if (_context.Institutions == null)
            {
                return NotFound();
            }
            var institution = await _context.Institutions.FindAsync(id);
            if (institution == null)
            {
                return NotFound();
            }

            _context.Institutions.Remove(institution);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InstitutionExists(int id)
        {
            return (_context.Institutions?.Any(e => e.InstitutionId == id)).GetValueOrDefault();
        }
    }
}
