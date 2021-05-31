using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnrollMent.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int StudID { get; set; }
        [Required]
        public string StudName { get; set; }
        [Required]
        public int StudAge { get; set; }
        [Required]
        public string StudAddress { get; set; }
        [Required]
        public string StudCourse { get; set; }
        [Required]
        public int StudSCYear { get; set; }
        [Required]
        public string StudSchool { get; set; }
        [Required]
        public string StudStreet { get; set; }
        [Required]
        public string StudCity { get; set; }

    }
}
