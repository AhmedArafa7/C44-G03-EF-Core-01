using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_EF01.Models
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public required int ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
    } // done
}
