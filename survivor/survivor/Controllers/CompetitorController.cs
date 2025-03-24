using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using survivor.Data;
using survivor.Models;

namespace survivor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompetitorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CompetitorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Competitor>>> GetAll()
        {
            return await _context.Competitors.Include(c => c.Category).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Competitor>> GetById(int id)
        {
            var competitor = await _context.Competitors.Include(c => c.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (competitor == null) return NotFound();
            return competitor;
        }

        [HttpGet("categories/{categoryId}")]
        public async Task<ActionResult<IEnumerable<Competitor>>> GetByCategoryId(int categoryId)
        {
            return await _context.Competitors.Where(x => x.CategoryId == categoryId).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Competitor>> Create(Competitor competitor)
        {
            _context.Competitors.Add(competitor);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = competitor.Id }, competitor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Competitor competitor)
        {
            if (id != competitor.Id) return BadRequest();

            _context.Entry(competitor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor == null) return NotFound();

            _context.Competitors.Remove(competitor);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
