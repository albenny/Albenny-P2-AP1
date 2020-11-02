using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Albenny_P2_AP1.Entidades;

namespace Albenny_P2_AP1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<TiposTareas> TiposTareas { get; set; }
        public DbSet<Proyectos> Proyectos { get; set; }
        //——————————————————————————————————————————————————————————————————————————————————————
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\ProyectoTareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas { TareaId = 1, TiposTarea = "Analisis" });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas { TareaId = 2, TiposTarea = "Diseño" });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas { TareaId = 3, TiposTarea = "Programación" });
            modelBuilder.Entity<TiposTareas>().HasData(new TiposTareas { TareaId = 4, TiposTarea = "Prueba" });
        }
    }
}