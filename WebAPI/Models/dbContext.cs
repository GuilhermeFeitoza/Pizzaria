﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAPI.Models
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
        public virtual DbSet<TbCliente> TbClientes { get; set; }
        public virtual DbSet<TbFuncionario> TbFuncionarios { get; set; }
        public virtual DbSet<TbIngrediente> TbIngredientes { get; set; }
        public virtual DbSet<TbPizza> TbPizzas { get; set; }
        public virtual DbSet<TbUsuario> TbUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-L0N3OP9\\FTZ;Initial Catalog=Pizzaria;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<TbAvaliacao>(entity =>
            {
                entity.HasKey(e => e.IdAvaliacao)
                    .HasName("PK__tbAvalia__78C432D85EBB45A7");

                entity.ToTable("tbAvaliacao");

                entity.Property(e => e.Ativo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbCliente");

                entity.Property(e => e.Ativo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).ValueGeneratedOnAdd();

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.ToTable("tbFuncionario");

                entity.Property(e => e.Ativo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DataAdmissao).HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbIngrediente>(entity =>
            {
                entity.HasKey(e => e.IdIngrediente)
                    .HasName("PK__tbIngred__3DA4DD6016AF3F5D");

                entity.ToTable("tbIngredientes");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPizza>(entity =>
            {
                entity.HasKey(e => e.IdPizza)
                    .HasName("PK__tbPizza__52072C78A2BFCED9");

                entity.ToTable("tbPizza");

                entity.Property(e => e.Nome)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Preco).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__tbUsuari__5B65BF97AC0D0B07");

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
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
