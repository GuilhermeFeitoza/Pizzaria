using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Pizzaria.Domain.Models;

#nullable disable

namespace Pizzaria.Domain
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAvaliacao> TbAvaliacaos { get; set; }
        public virtual DbSet<TbBebida> TbBebidas { get; set; }
        public virtual DbSet<TbCliente> TbClientes { get; set; }
        public virtual DbSet<TbFuncionario> TbFuncionarios { get; set; }
        public virtual DbSet<TbIngrediente> TbIngredientes { get; set; }
        public virtual DbSet<TbPedido> TbPedidos { get; set; }
        public virtual DbSet<TbPizza> TbPizzas { get; set; }
        public virtual DbSet<TbPizzaIngrediente> TbPizzaIngredientes { get; set; }
        public virtual DbSet<TbUsuario> TbUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-MT4EHQR\\DB;Initial Catalog=Pizzaria;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<TbAvaliacao>(entity =>
            {
                entity.HasKey(e => e.IdAvaliacao)
                    .HasName("PK__tbAvalia__78C432D88F885A32");

                entity.Property(e => e.Ativo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.Titulo).IsUnicode(false);
            });

            modelBuilder.Entity<TbBebida>(entity =>
            {
                entity.Property(e => e.Ativo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IdBebida).ValueGeneratedOnAdd();

                entity.Property(e => e.Nome).IsUnicode(false);
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__tbClient__D5946642D79AE591");

                entity.Property(e => e.Ativo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cpf).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Telefone).IsUnicode(false);
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.Property(e => e.Ativo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Senha).IsUnicode(false);

                entity.Property(e => e.Usuario).IsUnicode(false);
            });

            modelBuilder.Entity<TbIngrediente>(entity =>
            {
                entity.HasKey(e => e.IdIngrediente)
                    .HasName("PK__tbIngred__3DA4DD60AD382A6A");

                entity.Property(e => e.Descricao).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);
            });

            modelBuilder.Entity<TbPedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__tbPedido__9D335DC3D38EEF59");

                entity.Property(e => e.FormaPagamentoPedido).IsUnicode(false);

                entity.Property(e => e.StatusPedido)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TipoPedido)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbPizza>(entity =>
            {
                entity.HasKey(e => e.IdPizza)
                    .HasName("PK__tbPizza__52072C78AEA15B06");

                entity.Property(e => e.Nome).IsUnicode(false);
            });

            modelBuilder.Entity<TbPizzaIngrediente>(entity =>
            {
                entity.HasKey(e => e.IdPizzaIngrediente)
                    .HasName("PK__tbPizza___A3940042C09F00DD");

                entity.HasOne(d => d.IdIngredienteNavigation)
                    .WithMany(p => p.TbPizzaIngredientes)
                    .HasForeignKey(d => d.IdIngrediente)
                    .HasConstraintName("FK__tbPizza_I__IdIng__45F365D3");

                entity.HasOne(d => d.IdPizzaNavigation)
                    .WithMany(p => p.TbPizzaIngredientes)
                    .HasForeignKey(d => d.IdPizza)
                    .HasConstraintName("FK__tbPizza_I__IdPiz__44FF419A");
            });

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__tbUsuari__5B65BF97FB83C981");

                entity.Property(e => e.Ativo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Senha).IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbUsuarios)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__tbUsuario__IdCli__3F466844");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
