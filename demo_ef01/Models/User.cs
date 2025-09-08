using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    [Table("Users")]
    internal class User
    {
        // data annotation

        [Key]
        public int SSN { get; set; } // SSN is primary key with constraint(1,1)

        [Required]
        [Column("UserName" , TypeName = "varchar(50)")]
        [MaxLength(50 , ErrorMessage = "Name Must Be Less Than 51 Chars !")]
        [StringLength(3, ErrorMessage = "Name Must Be Greater Than 3 Chars !")]
//        [StringLength(maximumLength: 50 , MinimumLength = 3)]
        public /*requried*/ string UName { get; set; }

        [Required]
        [Range(20 , 50)]
        public int Age { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; } // ******** application validation

        [NotMapped]
        public int MyProperty { get; set; }
    }
}
