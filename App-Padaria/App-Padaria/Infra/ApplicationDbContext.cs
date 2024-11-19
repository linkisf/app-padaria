using App_Padaria.Models.Producao;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App_Padaria.Infra
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public DbSet<PaoModel> Pao { get; set; }
        public DbSet<TipoPlacaModel> TipoPlaca { get; set; }
        public DbSet<TipoMassaModel> TipoMassa { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PaoModel>()
                .ToTable("DOM_Pao");
            builder.Entity<PaoModel>()
                .Property(p => p.NomePao).IsRequired();


            builder.Entity<TipoPlacaModel>()
                .ToTable("DOM_TipoPlaca");
            builder.Entity<TipoPlacaModel>()
                .Property(p => p.NomeTipoPlaca).IsRequired();
            builder.Entity<TipoPlacaModel>()
                .Property(p => p.QuantidadePaes).IsRequired();


            builder.Entity<TipoMassaModel>()
                .ToTable("DOM_TipoMassa");
            builder.Entity<TipoMassaModel>()
                .Property(p => p.NomeTipoMassa).IsRequired();
        }


    }
}
