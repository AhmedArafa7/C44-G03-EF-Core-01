using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int Dept_ID { get; set; }

        public Department Department_id { get; set; }
        public Course_Inst Course_Insted_id { get; set; }
    } // done
}
