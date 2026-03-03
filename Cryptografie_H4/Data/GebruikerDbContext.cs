using Cryptografie_H4.Models;
using Microsoft.EntityFrameworkCore;

namespace Cryptografie_H4.Data
{
    public class GebruikerDbContext : DbContext
    {
        public GebruikerDbContext(DbContextOptions<GebruikerDbContext> options) : base(options)
        {
        }

        public DbSet<Gebruiker> Gebruiker { get; set; }
    }
}
 