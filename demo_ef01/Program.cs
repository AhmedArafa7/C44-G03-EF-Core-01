using ConsoleApp1.Contexts;
using ConsoleApp1.Models;
using demos_EF_core.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;


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

            //bool Flag = CompanyDbContextSeed.Seed(dbContext);

            //if (Flag)
            //    Console.WriteLine("Data seed done :D ");
            //else
            //    Console.WriteLine("Faild :( ");
            #endregion

            #endregion

            #region loading related data

            #region default related data

            //var Emp01 = dbContext.Employees.FirstOrDefault(e => e.Id == 5);

            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee name : {Emp01.Name}");
            //    Console.WriteLine($"Department number : {Emp01.EmpDeptId}");
            //    Console.WriteLine($"Department name : {Emp01.ManagedDept.DeptName}"); // related data
            //}

            ///*
            // * 
            // * select
            // * from employees E , Departments D
            // * where D.Id = E.DepatId
            // */

            //var EmpDept = (from D in dbContext.Departments
            //               where D.DeptId == Emp01.EmpDeptId
            //               select D).FirstOrDefault();

            //Console.WriteLine($"Department : {EmpDept?.DeptName}");

            #endregion

            #region eager loading

            //var Emp01 = dbContext.Employees.Include(e => e.ManagedDept).FirstOrDefault(e => e.Id == 5);

            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee name : {Emp01.Name}");
            //    Console.WriteLine($"Department number : {Emp01.EmpDeptId}");
            //    Console.WriteLine($"Department name : {Emp01.ManagedDept?.DeptName}");
            //}

            // Get employee with id = 6 and department which is managed by this employee


            //var EmpManager = dbContext.Employees.Include(e => e.ManagedDept).FirstOrDefault(e => e.Id == 6);

            //if (EmpManager == null)
            //{
            //    Console.WriteLine($"Emp name : {EmpManager.Name}");
            //    Console.WriteLine($"Dept id : {EmpManager.ManagedDept.DeptId}");
            //    Console.WriteLine($"Dept name : {EmpManager.ManagedDept.DeptName}");
            //}

            #endregion


            #endregion

            #region explicit loading

            // manual loading
            // two request
            // first request => retrive data
            // second request => retrive related data

            #region example 01

            //var Emp01 = dbContext.Employees.FirstOrDefault(e  => e.Id == 5); // data

            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"emp name : {Emp01.Name}");
            //    Console.WriteLine($"dept id : {Emp01.EmpDept}");
            //    // departmentName
            //    // Explicit

            //    dbContext.Entry(Emp01).Reference(e => e.ManagedDept).Load();
            //    // reference() => allowed with one navigational property
            //    Console.WriteLine($"dept name : {Emp01.ManagedDept.DeptName}");
            //}

            #endregion


            #region example 02

            // get dept and employee works on it

            var Dept01 = dbContext.Departments.FirstOrDefault(d => d.DeptId == 3);

            if (Dept01 != null)
                Console.WriteLine(Dept01.DeptName);

            // explicit loading => another request
            // collection() => work with many nav property
            //dbContext.Entry(Dept01).Collection(d => d.Employees).Load();
            dbContext.Entry(Dept01).Collection(d => d.Employees).Query().Where(e => e.Age <30).Load();

            foreach (var item in Dept01.Employees)
                Console.WriteLine($"    {item.Name}");

            #endregion


            #endregion

            #endregion

            #region session 04

            #region loading related data

            #region lazy loading

            /*
             * enable lazy loading :-
             *      1. install package => Microsoft.EntityFrameworkCore.Proxies
             *      2. configer this packrage in DbContext class
             *      3. all nav properties must be 'virtual' and vlasses must be 'public'
             * 
             * 
             */

            //var Emp01 = dbContext.Employees.FirstOrDefault(e => e.Id == 5);

            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee name : {Emp01.Name}");
            //    Console.WriteLine($"Department ID : {Emp01.DeptId}");
            //    Console.WriteLine($"Department name : {Emp01.ManagedDept.DeptName}");
            //}

            #endregion

            #endregion

            #region join category [LINQ]


            #region inner join

            #region get depertment that has employee

            // inner join
            /*
             * select e.id , e.name , d.deptid , d.deptname
             * from employee e , department d
             * where d.depId == e.DepartmentId
             */

            // fluant syntax
            //var result = dbContext.Departments.Join(dbContext.Employees,
            //                                        d => d.DeptId,
            //                                        e => e.DeptId,
            //                                        (d, e) => new
            //                                        {
            //                                            EmpID = e.Id,
            //                                            EmpName = e.Name,
            //                                            DeptId = d.DeptId,
            //                                            DeptName = d.DeptName,
            //                                        });

            // Query syntax
            //var Result = from D in dbContext.Departments
            //             join E in dbContext.Employees
            //             on D.DeptId equals E.DeptId
            //             select new
            //             {
            //                 EmpID = E.Id,
            //                 EmpName = E.Name,
            //                 DeptId = D.DeptId,
            //                 DeptName = D.DeptName,
            //             };

            #endregion

            #region get department managers

            //var result = dbContext.Employees.Join(dbContext.Departments,
            //                            e => e.Id,
            //                            d => d.ManagerId,
            //                            (e, d) => new
            //                            {
            //                                EmpID = e.Id,
            //                                EmpName = e.Name,
            //                                DeptId = d.DeptId,
            //                                DeptName = d.DeptName,
            //                            });

            #endregion

            #endregion

            #region Group join- Left outer join

            #region Get all departments that has employees or not

            //var result = dbContext.Departments.GroupJoin(dbContext.Employees,
            //                                            d => d.DeptId,
            //                                            e => e.DeptId,
            //                                            (d, e) => new
            //                                            {
            //                                                Depertment = d,
            //                                                Employee = e
            //                                            });

            //var result = from d in dbContext.Departments
            //             join emp in dbContext.Employees
            //             on d.DeptId equals emp.DeptId into Groups
            //             select new
            //             {
            //                 Department = d,
            //                 Employee = Groups
            //             };

            //foreach (var dept in result)
            //{
            //    Console.WriteLine($"DeptID : {dept.Department.DeptId} - DeptName : {dept.Depertment.DeptName}");
            //    foreach (var emp in dept.Employee)
            //        Console.WriteLine($"      {emp.Name}");

            //}

            #endregion


            #endregion

            #region Right outer join - self study

            // مش مدعول لانه نفس الليفت لكن بعكس ترتيب الجداول و لانه اقل استخداما

            #endregion

            #region cross join - self study

            // مدعوم و يستخدم لجمع جدولين مع بعض لكن دون تكرار

            #endregion

            #endregion

            #endregion


            Console.WriteLine("Done");

        } // Dispose()
    }
}
