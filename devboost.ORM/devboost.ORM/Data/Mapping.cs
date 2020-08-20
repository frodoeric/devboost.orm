using devboost.ORM.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace devboost.ORM.Data
{
    public class JogadorMapping : IEntityTypeConfiguration<Jogador>
    {
        public void Configure(EntityTypeBuilder<Jogador> builder)
        {
            //builder.HasKey(x => x.Id);
            //builder.ToTable("Jogador");
            //builder.HasMany("Clube", "Jogador");
            //builder.HasMany(c => c.Clube)
            //.Map(m => m.MapKey("Id_Clube"));
            //builder.HasMany()


            //builder.HasKey(j => new { j.Id_Clube, j.Id_Posicao .BookId, bc.CategoryId });
            //modelBuilder.Entity<BookCategory>()
            //    .HasOne(bc => bc.Book)
            //    .WithMany(b => b.BookCategories)
            //    .HasForeignKey(bc => bc.BookId);
            //modelBuilder.Entity<BookCategory>()
            //    .HasOne(bc => bc.Category)
            //    .WithMany(c => c.BookCategories)
            //    .HasForeignKey(bc => bc.CategoryId);

        }
    }

    public class PosicaoMapping : IEntityTypeConfiguration<Posicao>
    {
        public void Configure(EntityTypeBuilder<Posicao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Posicao");
        }
    }

    public class ClubeMapping : IEntityTypeConfiguration<Clube>
    {
        public void Configure(EntityTypeBuilder<Clube> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Clube");
        }
    }
}
