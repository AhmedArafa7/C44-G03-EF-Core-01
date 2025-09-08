using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_EF01.Models
{
    internal class Stud_Course
    {
        [Key]
        public int Stud_ID { get; set; }
        [Required]
        public int Course_ID { get; set; }
        public int Grade { get; set; }
    }
}
