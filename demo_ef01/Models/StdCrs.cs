using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demos_EF_core.Models
{
    internal class StdCrs
    {
        public Student StudentId { get; set; }
        public Course CourseId { get; set; }
        public int Grade { get; set; }
    }
}
