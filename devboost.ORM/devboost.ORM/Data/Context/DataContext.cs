using devboost.ORM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace devboost.ORM.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Clube> Clube { get; set; }
        public DbSet<Posicao> Posicao { get; set; }

        //public DataContext(DbContextOptions<DataContext> options) :
        //    base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=DEVBOOST_ORM;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Jogador>()
                .HasKey(jg => jg.Id);
            
            builder.Entity<Jogador>()
                .HasOne(x => x.Clube)
                .WithMany(x => x.Jogadores)
                .HasForeignKey(x => x.Id_Clube);

            builder.Entity<Jogador>()
                .HasOne(x => x.Posicao)
                .WithMany(x => x.Jogadores)
                .HasForeignKey(x => x.Id_Posicao);


            builder.Entity<Clube>()
                .HasKey(x => x.Id);
            builder.Entity<Clube>()
                .HasMany(x => x.Jogadores);

            builder.Entity<Posicao>()
                .HasKey(x => x.Id);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //}





        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Property("DataCadastro").CurrentValue = DateTime.Now;
        //        }

        //        if (entry.State == EntityState.Modified)
        //        {
        //            entry.Property("DataCadastro").IsModified = false;
        //        }
        //    }

        //    return base.SaveChanges();
        //}

    }
}
