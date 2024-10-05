using cineApi.Entidades;
using Microsoft.EntityFrameworkCore;

namespace cineApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Genero> generos { get; set; }
    }
}
