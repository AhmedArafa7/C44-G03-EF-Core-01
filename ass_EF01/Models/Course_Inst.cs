using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_EF01.Models
{
    internal class Course_Inst
    {
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluate { get; set; }

        public Instructor Instructor_id { get; set; }
        public Course Course_id { get; set; }
    } // done
}
