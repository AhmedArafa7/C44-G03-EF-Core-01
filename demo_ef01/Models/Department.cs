using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Department
    {

        public int DeptId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string DeptName { get; set; }

        // nav property

        [ForeignKey(nameof(ManagerId))]
        public int DepartmentId { get; set; }
        public Employee ManagerId { get; set; } = null!; // nav property | partial
    }
}
