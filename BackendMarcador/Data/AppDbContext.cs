using Microsoft.EntityFrameworkCore;
using BackendMarcador.Models;

namespace BackendMarcador.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Partido> Partidos { get; set; }
    }
}