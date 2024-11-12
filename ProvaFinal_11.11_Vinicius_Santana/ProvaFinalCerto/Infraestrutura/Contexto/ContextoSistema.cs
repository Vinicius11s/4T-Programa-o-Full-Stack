using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Contexto
{
    public class ContextoSistema : DbContext
    {
        public ContextoSistema()
        {
            this.Database.EnsureCreated();//comando para criar o bd;
        }


        //entidades que serão mapeadas pelo DbSet como tabelas no meu bd; (ADC TODAS)
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConexao = @"Server=LAB11-09;Database=dbSisPROVA;Integrated Security=True;TrustServerCertificate=True;";


            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(stringConexao);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>(e =>
            {
                e.Property(e => e.Nome).IsRequired().HasMaxLength(150);
                e.Property(e => e.Email).IsRequired().HasMaxLength(150);
            });

            // Configuração das entidades de Flat
            modelBuilder.Entity<Endereco>(f =>
            {
                f.Property(f => f.Rua).IsRequired();
                f.Property(f => f.Cidade).HasMaxLength(200).IsRequired();


                f.HasOne(f => f.Cliente)
                    .WithMany(e => e.Enderecos)
                    .HasForeignKey(f => f.idCliente)
                     .OnDelete(DeleteBehavior.SetNull);
            });
        }
    }
}
