﻿using Microsoft.EntityFrameworkCore;
using UniversidadApiBackend.Models.DataModels;

namespace UniversidadApiBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) { 
        
        }

        // TODO: Agregar DBSets (Tablas de nuestra base de datos)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
    }
}
