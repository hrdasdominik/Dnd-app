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
            modelBuilder.Entity<CharacterSheet.Root>().HasMany(sheet => sheet.AbilityScores).WithOne().HasForeignKey(con => con.IdChar);
        }
        public DbSet<CharacterSheet.Root> CharacterSheets { get; set; }
    }
}
