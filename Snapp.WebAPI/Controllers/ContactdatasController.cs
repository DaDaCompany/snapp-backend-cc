using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core;
using Entity;

namespace Snapp.WebAPI.Controllers
{
    [Route("api/contactdatas/")]
    [ApiController]
    public class ContactdatasController : ControllerBase
    {
        private readonly CoreContext _context;

        public ContactdatasController(CoreContext context)
        {
            _context = context;
        }

        // GET: api/Contactdatas
        [HttpGet("getall")]
        public async Task<ActionResult<IEnumerable<Contactdata>>> GetContactdatas()
        {
            return await _context.Contactdatas.ToListAsync();
        }

        // GET: api/Contactdatas/5
        [HttpGet("getbyid/{id}")]
        public async Task<ActionResult<Contactdata>> GetContactdata(string id)
        {
            var contactdata = await _context.Contactdatas.FindAsync(id);

            if (contactdata == null)
            {
                return NotFound();
            }

            return contactdata;
        }

        // PUT: api/Contactdatas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("updatebyid/{id}")]
        public async Task<IActionResult> PutContactdata(string id, Contactdata contactdata)
        {
            if (id != contactdata.Id)
            {
                return BadRequest();
            }

            _context.Entry(contactdata).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactdataExists(id))
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

        // POST: api/Contactdatas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("add")]
        public async Task<ActionResult<Contactdata>> PostContactdata(Contactdata contactdata)
        {
            _context.Contactdatas.Add(contactdata);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ContactdataExists(contactdata.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetContactdata", new { id = contactdata.Id }, contactdata);
        }

        // DELETE: api/Contactdatas/5
        [HttpDelete("deletebyid/{id}")]
        public async Task<IActionResult> DeleteContactdata(string id)
        {
            var contactdata = await _context.Contactdatas.FindAsync(id);
            if (contactdata == null)
            {
                return NotFound();
            }

            _context.Contactdatas.Remove(contactdata);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactdataExists(string id)
        {
            return _context.Contactdatas.Any(e => e.Id == id);
        }
    }
}
