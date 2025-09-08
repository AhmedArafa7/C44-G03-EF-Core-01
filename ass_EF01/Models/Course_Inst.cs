using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_EF01.Models
{
    internal class Course_Inst
    {
        [Key]
        public int inst_ID { get; set; }
        [Required]
        public int Course_ID { get; set; }
        public string evaluate { get; set; }
    } // done
}
