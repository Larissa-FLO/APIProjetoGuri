using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjetoFullStack1.Models
{
    public partial class projetoGuriContext : DbContext
    {
        public projetoGuriContext()
        {
        }

        public projetoGuriContext(DbContextOptions<projetoGuriContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aluno> Alunos { get; set; } = null!;
        public virtual DbSet<Turma> Turmas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasKey(e => e.IdAluno)
                    .HasName("PK__alunos__8092FCB384CA9662");

                entity.ToTable("alunos");

                entity.Property(e => e.CodTurma).HasColumnName("codTurma");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("date")
                    .HasColumnName("dataInicio");

                entity.Property(e => e.DataNasc)
                    .HasColumnType("date")
                    .HasColumnName("dataNasc");

                entity.Property(e => e.Frequencia).HasColumnName("frequencia");

                entity.Property(e => e.NomeAluno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeAluno");

                entity.Property(e => e.NomeResponsavel1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeResponsavel1");

                entity.Property(e => e.NomeResponsavel2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeResponsavel2");

                entity.Property(e => e.TelContato).HasColumnName("telContato");

                entity.HasOne(d => d.CodTurmaNavigation)
                    .WithMany(p => p.Alunos)
                    .HasForeignKey(d => d.CodTurma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__alunos__codTurma__398D8EEE");
            });

            modelBuilder.Entity<Turma>(entity =>
            {
                entity.HasKey(e => e.CodTurma)
                    .HasName("PK__turmas__8EE1EC2F224B1FD3");

                entity.ToTable("turmas");

                entity.Property(e => e.CodTurma).HasColumnName("codTurma");

                entity.Property(e => e.Instrumento)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("instrumento");

                entity.Property(e => e.ProfResponsavel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("profResponsavel");

                entity.Property(e => e.Turno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("turno");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
