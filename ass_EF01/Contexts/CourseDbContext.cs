using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ass_EF01.Models;
using Microsoft.EntityFrameworkCore;

namespace ass_EF01.Contexts
{
    internal class CourseDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; database = CourseRoute ; trusted_connection = true ; trustServerCertificate = true");
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
