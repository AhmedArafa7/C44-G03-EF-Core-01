using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
using demos_EF_core.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Contexts
{
    internal class CompanyDbContext : DbContext
    {
        // when you create new class 'DbContext'
        // you must download this package => Microsoft.EntityFrameworkCore.SqlServer
        // you can also download this package from 'package manager console'
        //      => PM> install-package Microsoft.EntityFrameworkCore.SqlServer

        public CompanyDbContext() : base()
        {
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connect between consoleApp => database
            // connection srting => serverName , database name
            //optionsBuilder.UseSqlServer("Data source = . ; initial catalog = companyRoute ; integrated Security = true");
            optionsBuilder.UseSqlServer("Server = . ; database = companyRoute; Trusted_connection = true ; trustServerCertificate = true");
        }



        #region fluentAPIS

        // Applay mapping with fluent APIS you must override 'onModelCreating'
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // here you can configure your models
            // like set primary key , foreign key , etc ...
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region one to one RS

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.ManagedDept)
                .WithOne(e => e.ManagerId)
                .HasForeignKey<Department>(d => d.ManagerId);

            #endregion

            #region one to many RS

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.EmpDeptId) // each employee must belong to departmant
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.EmpDeptId);
            #endregion

            #region many to many RS

            modelBuilder.Entity<Student>()
                .HasMany(c => c.Courses)
                .WithMany(s => s.Students)
                .UsingEntity<StdCrs>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId }); // composit primary key

            #endregion

            #region seed data through migration

            //modelBuilder.Entity<Department>()
            //    .HasData
            //    (
            //        new Department() { DeptId = 8 , DeptName = "Software"},
            //        new Department() { DeptId = 9 , DeptName = "Marketing" }
            //    );

            #endregion


        }
        #endregion

        // if tou want a model turned into table in database
        // you must use DbSet<>
        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> UsersTable { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Product> Producta { get; set; }

        public DbSet<Student> students { get; set; }

        public DbSet<Course> Courses { get; set; }
    }


}
