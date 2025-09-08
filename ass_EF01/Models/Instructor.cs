using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_EF01.Models
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Bouns { get; set; }
        public double Salary { get; set; }
        public string Adress { get; set; }
        public int HourRate { get; set; }
        [Required]
        public int Dept_ID { get; set; }
    } // done
}
