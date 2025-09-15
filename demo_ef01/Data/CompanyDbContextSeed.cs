using ConsoleApp1.Contexts;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace demos_EF_core.Data
{
    internal class CompanyDbContextSeed
    {
        // table employee

        public static bool Seed(CompanyDbContext dbContext)
        {

            try
            {
                if (!dbContext.Employees.Any())
                {
                    var EmpsData = File.ReadAllText("Files\\employees.json");

                    var Employees = JsonSerializer.Deserialize<List<Employee>>(EmpsData);

                    // add employees
                    if (Employees.Count > 0)
                    {
                        dbContext.Employees.AddRange(Employees); // add
                        dbContext.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
