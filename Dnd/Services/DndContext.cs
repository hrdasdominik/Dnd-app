using Dnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dnd.Services
{
    public class DndContext : DbContext
    {
        public DndContext(DbContextOptions<DndContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<CharacterSheet.Root> CharacterSheets { get; set; }
    }
}
