using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_EF01.Models
{
    internal class Course
    {
        public int ID { get; set; }
        public string Duration { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public int Top_ID { get; set; }

        public Topic Topic_id { get; set; }

        public Course_Inst Course_Insted_id { get; set; }
        public Stud_Course Stud_Courseed_id { get; set;  }
    } // done
}
