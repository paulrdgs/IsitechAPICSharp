using MangaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MangaAPI.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Utilisateur> Utilisateurs  { get; set; } 
        public DbSet<Livre> Livres  { get; set; } 
        public DbSet<Tome> Tomes  { get; set; }
        public DbSet<Collection> Collections  { get; set; } 
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}