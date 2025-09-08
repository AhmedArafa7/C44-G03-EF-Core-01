using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    // model == entity == dominEntity : POCO class
    internal class Employee
    {
        // mapping by convention
        public int Id { get; set; }
        // public numeric property named as [id , employeeId ]
        // automatically assumed to be primary key
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public int age { get; set; }
    }
}
