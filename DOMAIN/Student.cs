using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DOMAIN
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string StudentAddress { get; set; }
    }
}
