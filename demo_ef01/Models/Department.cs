using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace ConsoleApp1.Models
{
    internal class Department
    {

        public int DeptId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string DeptName { get; set; }

        // nav property

        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }

        [InverseProperty(nameof(Employee.ManagedDept))]
        public virtual Employee Manager { get; set; } = null!; // nav property | partial

        // one to many
        //[InverseProperty("EmployeeDepartment")]
        [InverseProperty(nameof(Employee.EmpDept))]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
