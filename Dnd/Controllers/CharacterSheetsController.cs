using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dnd.Models;
using Dnd.Services;
using Microsoft.AspNetCore.Cors;

namespace Dnd.Controllers
{
    [EnableCors]
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
        public async Task<ActionResult<IEnumerable<CharacterSheet.Root>>> GetCharacterSheets()
        {
            var db = _context.CharacterSheets.Include(sheet => sheet.abilityScores).Include(sheet => sheet.abilityModifiers)
                .Include(sheet => sheet.savingThrows).Include(sheet => sheet.skills).ToListAsync();
            return await db;
        }
    }
}
