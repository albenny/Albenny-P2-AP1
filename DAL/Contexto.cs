using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Albenny_P2_AP1.Entidades;
using Albenny_P2_AP1.BLL;

namespace Albenny_P2_AP1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<TiposTareas> TiposTareas { get; set; }
        public DbSet<Proyectos> Proyectos { get; set; }
        //——————————————————————————————————————————————————————————————————————————————————————
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Albenny_P2_AP1.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas { TipoTareasId = 1, TipoTarea = "Analisis" });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas { TipoTareasId = 2, TipoTarea = "Diseño" });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas { TipoTareasId = 3, TipoTarea = "Programación" });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas { TipoTareasId = 4, TipoTarea = "Prueba" });
        }
    }
}