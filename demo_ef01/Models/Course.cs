using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demos_EF_core.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // nav property m to m with student
        public ICollection<Student> Students { get; set; }
    }
}
