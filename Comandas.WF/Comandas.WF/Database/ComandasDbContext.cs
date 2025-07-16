using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comandas.WF.Models;
using Comandas.WF.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Comandas.WF.Database
{
    public class ComandasDbContext : DbContext
    {
        public ComandasDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ComandasDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comanda>()
                .HasMany<ComandaItens>()
                    .WithOne(ci => ci.Comanda)
                .HasForeignKey(ci => ci.ComandaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ComandaItens>()
                .HasOne(ci => ci.Comanda)
                    .WithMany(c => c.ComandaItens)
                .HasForeignKey(ci => ci.ComandaId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ComandaItens>()
                .HasOne(ci => ci.CardapioItem)
                    .WithMany()
                .HasForeignKey(ci => ci.CardapioItemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PedidoCozinha>()
                .HasMany<PedidoCozinhaItem>()
                    .WithOne(pci => pci.PedidoCozinha)
                .HasForeignKey(pci => pci.PedidoCozinhaId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PedidoCozinhaItem>()
                .HasOne(pc => pc.PedidoCozinha)
                    .WithMany(pci => pci.PedidoCozinhaItens)
                .HasForeignKey(pc => pc.PedidoCozinhaId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PedidoCozinhaItem>()
                .HasOne(ci => ci.ComandaItem)
                    .WithMany()
                .HasForeignKey(ci => ci.ComandaItemId)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CardapioItem> CardapioItems { get; set; }
        public DbSet<PedidoCozinha> PedidosCozinha { get; set; }

        public DbSet<Comanda> Comandas { get; set; }

        public DbSet<Mesa> Mesas { get; set; }

        public DbSet<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }

        public DbSet<ComandaItens> ComandaItens { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }

}
