using InheritanceMapping.Context;
using Microsoft.EntityFrameworkCore;

namespace InheritanceMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region inhertance Mapping

            using CompanyRouteG02DbContext dbContext = new CompanyRouteG02DbContext();
            // open connection with sql server

            #region 1. table per concrete type [TPCT]

            //FullTimeEmployee ftEmp = new FullTimeEmployee()
            //{
            //    Name = "Ahmed",
            //    Age = 24,
            //    Salary = 5000,
            //    StartDate = DateTime.Now,
            //    Address = "cairo"
            //};

            //PartTimeEmployee ptEmp = new PartTimeEmployee()
            //{
            //    Name = "Aya",
            //    Age = 20,
            //    Address = "Tanta",
            //    CountOfHours = 70,
            //    HourlyRate = 200
            //};

            //dbContext.Add(ftEmp);
            //dbContext.Add(ptEmp);
            //dbContext.SaveChanges();

            //var FTE = (from fte in dbContext.FullTimeEmployees
            //           select fte).FirstOrDefault();

            //var PTE = dbContext.PartTimeEmployees.FirstOrDefault();

            //Console.WriteLine(FTE.Name);
            //Console.WriteLine(PTE.Name);

            #endregion

            #region 2. table per hierachy [TPH] - defualt for EF core

            //FullTimeEmployee ftEmp = new FullTimeEmployee()
            //{
            //    Name = "Ahmed",
            //    Age = 24,
            //    Salary = 5000,
            //    StartDate = DateTime.Now,
            //    Address = "cairo"
            //};

            //PartTimeEmployee ptEmp = new PartTimeEmployee()
            //{
            //    Name = "Aya",
            //    Age = 20,
            //    Address = "Tanta",
            //    CountOfHours = 70,
            //    HourlyRate = 200
            //};

            //dbContext.Add(ftEmp);
            //dbContext.Add(ptEmp);
            //dbContext.SaveChanges();

            //var Emps = from e in dbContext.Employees
            //           select e;

            //foreach (var item in Emps.OfType<PartTimeEmployee>())
            //    Console.WriteLine(item.Name);

            #endregion

            #region 3. table per type [TPT]

            //FullTimeEmployee ftEmp = new FullTimeEmployee()
            //{
            //    Name = "Ahmed",
            //    Age = 24,
            //    Salary = 5000,
            //    StartDate = DateTime.Now,
            //    Address = "cairo"
            //};

            //PartTimeEmployee ptEmp = new PartTimeEmployee()
            //{
            //    Name = "Aya",
            //    Age = 20,
            //    Address = "Tanta",
            //    CountOfHours = 70,
            //    HourlyRate = 200
            //};


            //dbContext.Add(ftEmp);
            //dbContext.Add(ptEmp);
            //dbContext.SaveChanges();

            //var Emps = (from e in dbContext.Employees
            //           select e).ToList();

            //if (Emps is not null)
            //{
            //    foreach (var item in Emps.OfType<PartTimeEmployee>())
            //        Console.WriteLine(item.Name);
            //}

            #endregion

            #endregion

        }
    }
}
