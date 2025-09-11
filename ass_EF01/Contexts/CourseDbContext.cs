using ass_EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ass_EF01.Contexts
{
    internal class CourseDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; database = CourseRoute ; trusted_connection = true ; trustServerCertificate = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // here you can configure your models
            // like set primary key , foreign key , etc ...
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Course>()
                .HasOne(e => e.Topic_id)
                .WithOne(e => e.Topiced_id)
                .HasForeignKey<Topic>(e => e.ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(e => e.Course_id)
                .WithOne(e => e.Course_Insted_id)
                .HasForeignKey<Course>(e => e.ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(e => e.Instructor_id)
                .WithOne(e => e.Course_Insted_id)
                .HasForeignKey<Instructor>(e => e.ID);

            modelBuilder.Entity<Instructor>()
                .HasOne(e => e.Department_id)
                .WithOne(e => e.Instructored_id)
                .HasForeignKey<Department>(e => e.ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(e => e.Student_id)
                .WithOne(e => e.Stud_Courseed_id)
                .HasForeignKey<Student>(e => e.ID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(e => e.Student_id)
                .WithOne(e => e.Stud_Courseed_id)
                .HasForeignKey<Student>(e => e.ID);

            modelBuilder.Entity<Student>()
                .HasOne(e => e.Department_id)
                .WithOne(e => e.Studented_id)
                .HasForeignKey<Department>(e => e.ID);

            modelBuilder.Entity<Course>()
                .HasOne(e => e.Topic_id)
                .WithOne(e => e.Topiced_id)
                .HasForeignKey<Topic>(e => e.ID);

            modelBuilder.Entity<Course>()
                .HasOne(e => e.Topic_id)
                .WithOne(e => e.Topiced_id)
                .HasForeignKey<Topic>(e => e.ID);

            modelBuilder.Entity<Course>()
                .HasOne(e => e.Topic_id)
                .WithOne(e => e.Topiced_id)
                .HasForeignKey<Topic>(e => e.ID);

            modelBuilder.Entity<Course>()
                .HasOne(e => e.Topic_id)
                .WithOne(e => e.Topiced_id)
                .HasForeignKey<Topic>(e => e.ID);

            modelBuilder.Entity<Course>()
                .HasOne(e => e.Topic_id)
                .WithOne(e => e.Topiced_id)
                .HasForeignKey<Topic>(e => e.ID);

        }

        public DbSet<Student> student {  get; set; }
        public DbSet<Stud_Course> stud_course { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<Course_Inst> course_Inst { get; set; }
        public DbSet<Topic> topic { get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<Instructor> instructor { get; set; }
    }
}
