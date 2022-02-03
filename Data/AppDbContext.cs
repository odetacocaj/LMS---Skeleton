
using LearningEnvironment2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Data
{
    public class AppDbContext : IdentityDbContext <ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Student>().HasKey(cs => new
            {
                cs.CourseId,
                cs.StudentId
            });

            modelBuilder.Entity<Course_Student>().HasOne(s => s.Student).WithMany(cs => cs.Course_Student).HasForeignKey(s => s.StudentId);
            modelBuilder.Entity<Course_Student>().HasOne(s => s.Course).WithMany(cs => cs.Course_Student).HasForeignKey(s => s.CourseId);
            base.OnModelCreating(modelBuilder);
        }
      
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Professor> Professors { get; set; }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet <Admin> Admins { get; set; }
        public DbSet<Course_Student> Course_Students { get; set; }
    }
}
