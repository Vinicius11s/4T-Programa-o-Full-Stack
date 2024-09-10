using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infoestrutura.Contexto
{
    public class ContextoEmpresa : DbContext
    {
        //construtor
        public ContextoEmpresa()
        {
            this.Database.EnsureCreated();//comando para criar ou alterar o bd;
        }

        //entidades que serão mapeadas pelo DbSet como tabelas no meu bd;
        public DbSet<Produto> produtos { get; set; }
        public DbSet<Categoria> categorias { get; set; }

        //estabelecer conexão com meu banco de dados

        //sobre escrevendo um método que já está na classe mãe;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConexao = @"Server=LAB11-09;
                                DataBase=dbEmpresa2025;integrated security=true; TrustServerCertificate=True;";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(stringConexao);
            }
        }


        //metodo indica qual a precisao do cod, descrição e etc
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Categoria>(e => {               //pegue uma entidade para configurarmos'Categoria'                                         //corpo da função
                e.Property(c => c.descricao).HasMaxLength(150); //descrição maximo de caracteres;
            });
            modelBuilder.Entity<Produto>(e => { 
                e.Property(p => p.descricao).HasMaxLength(150);
                e.Property(p => p.valor).HasPrecision(8, 2); //precisão do valor 8 digitos, 2 dps da virgula;

                //relacionamento (somente a q recebe a chave estrangeira);
                e.HasOne(p => p.categoria) //prop lado um;
                .WithMany(p => p.produtos) //prop lado Muitos;
                .HasForeignKey(p => p.idCategoria) //prop chave estrangeira;
                .HasConstraintName("FK_Categoria_Produto") //nome do relacionamento;
                .OnDelete(DeleteBehavior.NoAction); //configuração da exclusao;
            });
        }
    }
}
