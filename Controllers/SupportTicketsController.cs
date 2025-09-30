using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimerParcial.Data;
using PrimerParcial.Models;

namespace PrimerParcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportTicketsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SupportTicketsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportTickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportTicket>>> GetSupportTickets()
        {
            return await _context.SupportTickets.ToListAsync();
        }

        // GET: api/SupportTickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportTicket>> GetSupportTicket(int id)
        {
            var ticket = await _context.SupportTickets.FindAsync(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return ticket;
        }

        // POST: api/SupportTickets
        [HttpPost]
        public async Task<ActionResult<SupportTicket>> PostSupportTicket(SupportTicket ticket)
        {
            _context.SupportTickets.Add(ticket);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSupportTicket), new { id = ticket.Id }, ticket);
        }

        // PUT: api/SupportTickets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupportTicket(int id, SupportTicket ticket)
        {
            if (id != ticket.Id)
            {
                return BadRequest();
            }

            _context.Entry(ticket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.SupportTickets.Any(e => e.Id == id))
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

        // DELETE: api/SupportTickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupportTicket(int id)
        {
            var ticket = await _context.SupportTickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.SupportTickets.Remove(ticket);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
