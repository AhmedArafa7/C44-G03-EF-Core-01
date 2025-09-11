using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int Age { get; set; }
        // value
        // not allow null
        // int mapped to int


        // navigation property
        // represent relationship of 1 to 1
        // EF core by convention => Department has one employee to manage it


        // FK
     //   [ForeignKey(nameof(ManagedDept))]
     //   public int ManageDeptId { get; set; }

        public Department ManagedDept { get; set; } = null!; // nav property | total

        public Address empaddress { get; set; } = null!;
    }
}
