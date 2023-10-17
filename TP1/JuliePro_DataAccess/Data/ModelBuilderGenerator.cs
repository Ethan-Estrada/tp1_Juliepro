using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuliePro_DataModels.Entities;

namespace JuliePro_DataAccess.Data
{
    public static class ModelBuilderGenerator
    {
            public static void GenerateData(this ModelBuilder builder)
            {
            #region Données pour Speciality
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 1, Name = "Perte de poids" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 2, Name = "Course" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 3, Name = "Althérophilie" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 4, Name = "Réhabilitation" });
            #endregion

            #region Données pour Trainer
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 1, FirstName = "Chrysal", LastName = "Lappierre", AuthorEmail = "Chrystal.lapierre@juliepro.ca",Biographie = "Hola1", Speciality_Id = 1, Photo = "8624af64-2685-459a-a1cc-816c0695d760.png", Active = true });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 2, FirstName = "Félix", LastName = "Trudeau", AuthorEmail = "Felix.trudeau@juliePro.ca", Biographie = "Hola2", Speciality_Id = 2, Photo = "a202bae3-e6bb-40f0-84cf-e4b11627ba1c.png", Active = true });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 3, FirstName = "François", LastName = "Saint-John", AuthorEmail = "Frank.StJohn@juliepro.ca", Biographie = "Hola3", Speciality_Id = 1, Photo = "aedd9532-1395-42a2-8ae6-56f0e2ab49b5.png", Active = false });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 4, FirstName = "Jean-Claude", LastName = "Bastien", AuthorEmail = "JC.Bastien@juliepro.ca", Biographie = "Hola4", Speciality_Id = 4, Photo = "d7bcc6d9-0599-42aa-8305-3c1ae5a4505c.png", Active = true });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 5, FirstName = "Jin Lee", LastName = "Godette", AuthorEmail = "JinLee.godette@juliepro.ca", Biographie = "Hola5", Speciality_Id = 3, Photo = "E3Rcc6d9-0599-42aa-8305-3c1ae5a4512v.png", Active = true });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 6, FirstName = "Karine", LastName = "Lachance", AuthorEmail = "Karine.Lachance@juliepro.ca", Biographie = "Hola6", Speciality_Id = 2, Photo = "b333bae3-e6bb-40f0-84cf-e4b11627ba1c.png", Active = true });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 7, FirstName = "Ramone", LastName = "Esteban", AuthorEmail = "Ramone.Esteban@juliepro.ca", Biographie = "Hola7", Speciality_Id = 3, Photo = "waqd9532-1395-42a2-8ae6-56f0e2ab49e9.png", Active = false });
            #endregion

            #region Données pour Customer
            builder.Entity<Customer>().HasData(new Customer() { Id = 1, FirstName = "Arthur", LastName = "Laroche", AuthorEmail = "arthurLaroche@gmail.com", BirthDate = new DateTime(1965, 10, 04, 00, 00, 00), Photo = "", Trainer_Id = 3,ScheduledSession_Id = 3 });
            builder.Entity<Customer>().HasData(new Customer() { Id = 2, FirstName = "Délima", LastName = "Caillou", AuthorEmail = "DelimaCaillou@gmail.com", BirthDate = new DateTime(1965, 10, 04, 00, 00, 00), Photo = "", Trainer_Id = 2, ScheduledSession_Id = 3 });
            builder.Entity<Customer>().HasData(new Customer() { Id = 3, FirstName = "Fred", LastName = "Caillou", AuthorEmail = "fredcaillou@gmail.com", BirthDate = new DateTime(1965, 10, 04, 00, 00, 00), Photo = "", Trainer_Id = 3, ScheduledSession_Id = 3 });
            builder.Entity<Customer>().HasData(new Customer() { Id = 4, FirstName = "Bertha", LastName = "Laroche", AuthorEmail = "berthaLaroche@gmail.com", BirthDate = new DateTime(1965, 10, 04, 00, 00, 00), Photo = "", Trainer_Id = 1, ScheduledSession_Id = 3 });
            #endregion

            #region Données pour Objective
            builder.Entity<Objective>().HasData(new Objective() { Id = 1, Name = "", LostWeight = 5, DistanceKm = 0, AchievedDate = new DateTime(2021, 09, 01, 00, 00, 00), Customer_Id = 1 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 2, Name = "", LostWeight = 5, DistanceKm = 0, AchievedDate = new DateTime(2021, 10, 01, 00, 00, 00), Customer_Id = 1 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 3, Name = "", LostWeight = 5, DistanceKm = 0, Customer_Id = 1 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 4, Name = "", LostWeight = 10, DistanceKm = 0, AchievedDate = new DateTime(2022, 05, 11, 00, 00, 00), Customer_Id = 2 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 5, Name = "", LostWeight = 5, DistanceKm = 0, Customer_Id = 2 });

            #endregion

            #region Données pour Training
            builder.Entity<Training>().HasData(new Training() { Id = 1, Name = "step", Category = "cardio" });
            builder.Entity<Training>().HasData(new Training() { Id = 2, Name = "yoga", Category = "étirement" });
            builder.Entity<Training>().HasData(new Training() { Id = 3, Name = "crossfit", Category = "musculaire" });
            builder.Entity<Training>().HasData(new Training() { Id = 4, Name = "course", Category = "cardio" });
            builder.Entity<Training>().HasData(new Training() { Id = 5, Name = "zumba", Category = "cardio" });
            builder.Entity<Training>().HasData(new Training() { Id = 6, Name = "spinning", Category = "musculaire" });
            builder.Entity<Training>().HasData(new Training() { Id = 7, Name = "taichi", Category = "étirement" });
            #endregion

            #region Données pour Equipment
            builder.Entity<Equipment>().HasData(new Equipment() { Id = 1, Name = "vélo" });
            builder.Entity<Equipment>().HasData(new Equipment() { Id = 2, Name = "ensemble dumbels" });
            builder.Entity<Equipment>().HasData(new Equipment() { Id = 3, Name = "tapis" });
            builder.Entity<Equipment>().HasData(new Equipment() { Id = 4, Name = "step" });
            builder.Entity<Equipment>().HasData(new Equipment() { Id = 5, Name = "ensemble barre altère" });
            builder.Entity<Equipment>().HasData(new Equipment() { Id = 6, Name = "bloc yoga" });
            builder.Entity<Equipment>().HasData(new Equipment() { Id = 7, Name = "elastiques" });
            builder.Entity<Equipment>().HasData(new Equipment() { Id = 8, Name = "ballon d'exercice" });
            #endregion
        }
    }
}
