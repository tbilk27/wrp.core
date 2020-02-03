using Microsoft.EntityFrameworkCore;
using wrp.core.Database.Configurations;
using wrp.core.Entity;

namespace wrp.core.Database
{
    public class WrpContext : DbContext
    {
        public DbSet<Acesso> Acessos { get; set; }
        public DbSet<AcessoGrupo> AcessosGrupos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.EnableSensitiveDataLogging());
            optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
        }

        public void RecriarBanco()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AcessoConfiguration());
            modelBuilder.ApplyConfiguration(new AcessoGrupoConfiguration());
        }
    }
}