using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dnd.Models;
using Dnd.Services;

namespace Dnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterSheetsController : ControllerBase
    {
        private readonly DndContext _context;

        public CharacterSheetsController(DndContext context)
        {
            _context = context;
        }

        // GET: api/CharacterSheets

        [HttpGet]
        public async Task<ActionResult<ICollection<CharacterSheet.Root>>> GetCharacterSheets()
        {
            var db = _context.CharacterSheets.ToListAsync();
            return await db;
        }

        // GET: api/CharacterSheets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterSheet.Root>> GetCharacterSheet(int id)
        {
            var characterSheet = await _context.CharacterSheets.FindAsync(id);

            if (characterSheet == null)
            {
                return NotFound();
            }

            return characterSheet;
        }

        // PUT: api/CharacterSheets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterSheet(int id, CharacterSheet.Root characterSheet)
        {
            if (id != characterSheet.Id)
            {
                return BadRequest();
            }

            _context.Entry(characterSheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterSheetExists(id))
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

        // POST: api/CharacterSheets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharacterSheet>> PostCharacterSheet(CharacterSheet.Root characterSheet)
        {
            _context.CharacterSheets.Add(characterSheet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCharacterSheet", new { id = characterSheet.Id }, characterSheet);
        }

        // DELETE: api/CharacterSheets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacterSheet(int id)
        {
            var characterSheet = await _context.CharacterSheets.FindAsync(id);
            if (characterSheet == null)
            {
                return NotFound();
            }

            _context.CharacterSheets.Remove(characterSheet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacterSheetExists(int id)
        {
            return _context.CharacterSheets.Any(e => e.Id == id);
        }
    }
}
