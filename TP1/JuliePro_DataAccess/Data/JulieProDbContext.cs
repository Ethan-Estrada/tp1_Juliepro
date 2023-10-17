using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuliePro_DataAccess.Data;
using JuliePro_DataModels.Entities;

namespace JuliePro_DataAccess
{
    public class JulieProDbContext : DbContext
    {
        public JulieProDbContext()
        { 
        
        }

        public JulieProDbContext(DbContextOptions<JulieProDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=JulieProDb;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<ScheduledSession> ScheduledSessions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Générer des données de départ
            modelBuilder.GenerateData(); 
        }


    }
}
