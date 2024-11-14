using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Pizzaria.Domain.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAvaliacao> TbAvaliacaos { get; set; }
        public virtual DbSet<TbBebida> TbBebidas { get; set; }
        public virtual DbSet<TbCliente> TbClientes { get; set; }
        public virtual DbSet<TbFuncionario> TbFuncionarios { get; set; }
        public virtual DbSet<TbIngrediente> TbIngredientes { get; set; }
        public virtual DbSet<TbPedido> TbPedidos { get; set; }
        public virtual DbSet<TbPedidoProduto> TbPedidoProdutos { get; set; }
        public virtual DbSet<TbPizza> TbPizzas { get; set; }
        public virtual DbSet<TbPizzaIngrediente> TbPizzaIngredientes { get; set; }
        public virtual DbSet<TbUsuario> TbUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-GI024AH;Initial Catalog=Pizzaria;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAvaliacao>(entity =>
            {
                entity.HasKey(e => e.IdAvaliacao)
                    .HasName("PK__tbAvalia__78C432D835E8BC95");

                entity.ToTable("tbAvaliacao");

                entity.Property(e => e.Ativo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataPedido).HasColumnType("datetime");

                entity.Property(e => e.NomeAvaliador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TbAvaliacaos)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK__tbAvaliac__IdPed__160F4887");
            });

            modelBuilder.Entity<TbBebida>(entity =>
            {
                entity.HasKey(e => e.IdBebida)
                    .HasName("PK__tbBebida__A111F0E36ECD3DDC");

                entity.ToTable("tbBebidas");

                entity.Property(e => e.Ativo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Preco).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__tbClient__D59466428A8C8115");

                entity.ToTable("tbCliente");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.ToTable("tbFuncionario");

                entity.Property(e => e.Ativo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DataAdmissao).HasColumnType("datetime");

                entity.Property(e => e.DataNascimento).HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbIngrediente>(entity =>
            {
                entity.HasKey(e => e.IdIngrediente)
                    .HasName("PK__tbIngred__3DA4DD603E4BF00F");

                entity.ToTable("tbIngredientes");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Preco).HasColumnType("money");
            });

            modelBuilder.Entity<TbPedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__tbPedido__9D335DC3D9D7233B");

                entity.ToTable("tbPedido");

                entity.Property(e => e.DataPedido).HasColumnType("datetime");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FormaPagamentoPedido)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusPedido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TipoPedido)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ValorPedido).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TbPedidoProduto>(entity =>
            {
                entity.HasKey(e => e.IdPedidoProduto)
                    .HasName("PK__tbPedido__6A8B1AE899F0DE3B");

                entity.ToTable("tbPedido_Produto");

                entity.HasOne(d => d.IdBebidaNavigation)
                    .WithMany(p => p.TbPedidoProdutos)
                    .HasForeignKey(d => d.IdBebida)
                    .HasConstraintName("FK__tbPedido___IdBeb__04E4BC85");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TbPedidoProdutos)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK__tbPedido___IdPed__02FC7413");

                entity.HasOne(d => d.IdPizzaNavigation)
                    .WithMany(p => p.TbPedidoProdutos)
                    .HasForeignKey(d => d.IdPizza)
                    .HasConstraintName("FK__tbPedido___IdPiz__03F0984C");
            });

            modelBuilder.Entity<TbPizza>(entity =>
            {
                entity.HasKey(e => e.IdPizza)
                    .HasName("PK__tbPizza__52072C787A238516");

                entity.ToTable("tbPizza");

                entity.Property(e => e.Nome)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Preco).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TbPizzaIngrediente>(entity =>
            {
                entity.HasKey(e => e.IdPizzaIngrediente)
                    .HasName("PK__tbPizza___A39400424B70B16C");

                entity.ToTable("tbPizza_Ingrediente");

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
                    .HasName("PK__tbUsuari__5B65BF97C7801380");

                entity.ToTable("tbUsuario");

                entity.Property(e => e.Ativo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Nome)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasMaxLength(200)
                    .IsUnicode(false);

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
