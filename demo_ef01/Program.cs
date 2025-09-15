using ConsoleApp1.Contexts;
using ConsoleApp1.Models;
using demos_EF_core.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext(); // open connection

            #region session 01

            #region entity framework core

            /*
             * features :-
             *      - object relational mapper (ORM) => fully ORM
             *      - auto tracker
             *      - support linq
             *      - support migrations
             *      - support multiple database
             *      - cross platform
             * 
             * disadvantages :-
             * - performance (auto tracker)
             * - complexity
             * 
             */

            #endregion

            #region ADO.NET

            /*
             * features :-
             *      - low level framework
             *      - no tracking
             *      - manual connection
             *      - direct access to SQL
             * 
             */

            #endregion

            #region Dapper

            /*
             * features :-
             *      - lightweight for simple , small projects
             *      - no tracker
             *      - no migrations
             *      - simple API (dapper)
             *      - faster
             *      - easy to use
             *      - micro ORM
             *          limited features
             * 
             */

            #endregion

            #region DbContext

            //CompanyDbContext db = new CompanyDbContext();
            //// open connection with database

            //// close connection
            //try
            //{

            //}
            //finally
            //{
            //    db.Dispose();
            //    // close connection => Dispose()
            //}

            using CompanyDbContext db = new CompanyDbContext();

            //db.Database.Migrate();

            // to applay migrations
            // you must download this package Microsoft.EntityFrameworkCore.Tools

            // to applay database in 

            #endregion

            #region migrations

            /*
             * to remove migration
             * 1. you must revert this migration
             *      update-database 0
             * 2. remove-migration
             * 
             */

            #endregion

            #endregion

            #region session 02

            #region query object model [CRUD Opeartions]

            //using CompanyDbContext dbContext = new CompanyDbContext();

            #region add new records

            #region query object model

            //// to add new data in database

            //// connect with database
            //// by default EF core contain auto tracker => track all object 
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //Employee emp01 = new Employee()
            //{
            //    //Id = 1,
            //    Name = "ahmed",
            //    Salary = 40000,
            //    Age = 22
            //};

            //Console.WriteLine(dbContext.Entry<Employee>(emp01).State); // detached

            //// add emp01 to table employees in database

            //// 1)
            //dbContext.Employees.Add(emp01);
            //// 2)
            //dbContext.Set<Employee>().Add(emp01);
            //// 3)
            //dbContext.Add(emp01);

            ////dbContext.Entry<Employee>(emp01).State; // auto tracking 

            //Console.WriteLine(dbContext.Entry<Employee>(emp01).State); // added

            //// savingchanges() => applay database
            //dbContext.SaveChanges();

            #endregion

            #region get data from table - select

            ////var emp01 = dbContext.Employees.Where(e => e.Id == 1).FirstOrDefault();
            //var emp01 = dbContext.Employees.FirstOrDefault(e => e.Id == 1);

            ///*
            // * select top(1)
            // * from employees
            // * where id = 1
            // */

            //if (emp01 != null)
            //{
            //    Console.WriteLine($"id : {emp01.Id}\nName : {emp01.Name}\nSalary : {emp01.Salary}");
            //}

            #endregion


            #region update data in table - update

            //var emp01 = dbContext.Employees.FirstOrDefault(e => e.Id == 1);

            //if (emp01 != null)
            //{
            //    emp01.Name = "ahmed";
            //    Console.WriteLine(dbContext.Entry<Employee>(emp01).State);
            //    dbContext.SaveChanges();
            //}

            #endregion

            #region remove data from table - delete

            //var emp01 = dbContext.Employees.FirstOrDefault(e => e.Id == 1);

            //if (emp01 != null)
            //{
            //    //dbContext.Employees.Remove(emp01);
            //    dbContext.Remove(emp01);
            //    Console.WriteLine(dbContext.Entry<Employee>(emp01).State);
            //    dbContext.SaveChanges();
            //}

            #endregion


            #endregion

            #endregion

            #region relationships between classes

            /*
             * you can make relation between 2 tables by 3 ways :-
             *      1. navigation property
             *      2. fluent APIs
             *      3. by convention
             * 
             */

            #endregion

            #region one to one [optional - total]

            #endregion

            #region one to one [total - total]

            #endregion

            #region one to one [optional - optional] self study

            #endregion

            #endregion

            #region session 03

            #region data seed

            /*
             * 3 ways
             *      1- manual data seeding
             *      2- migration data seeding
             *      3- dynamic data seeding
             */

            #region manual data seeding

            //Department Dept01 = new Department()
            //{
            //    DeptName = "HR"
            //};

            //dbContext.Add(Dept01);
            //dbContext.SaveChanges();

            //List<Department> departments = new List<Department>()
            //{
            //    new Department() {DeptName = "IT"},
            //    new Department() {DeptName = "Dev"},
            //    new Department() {DeptName = "Sales"},
            //    new Department() {DeptName = "Testing"}
            //};

            //dbContext.AddRange(departments);
            //dbContext.SaveChanges();



            #endregion

            #region migration data seeding

            #endregion

            #region dynamic data seeding

            bool Flag = CompanyDbContextSeed.Seed(dbContext);

            if (Flag)
                Console.WriteLine("Data seed done :D ");
            else
                Console.WriteLine("Faild :( ");
            #endregion

            #endregion

            #region MyRegion

            #endregion

            #region MyRegion

            #endregion

            #region MyRegion

            #endregion

            #region MyRegion

            #endregion

            #region MyRegion

            #endregion

            #endregion


            Console.WriteLine("Didnot Done");

        } // Dispose()
    }
}
