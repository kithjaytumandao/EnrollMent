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
        [StringLength(30)]
        public string StudName { get; set; }
        [Required]
        [Range(10,99)]
        public int StudAge { get; set; }
        [Required]
        [StringLength(50)]
        public string StudAddress { get; set; }
        [Required]
        [StringLength(30)]
        public string StudCourse { get; set; }
        [Required]
        [StringLength(30)]
        [Range(1, 6)]
        public int StudSCYear { get; set; }
        [Required]
        [StringLength(100)]
        public string StudSchool { get; set; }
        [Required]
        [StringLength(100)]
        public string StudStreet { get; set; }
        [Required]
        [StringLength(100)]
        public string StudCity { get; set; }

    }
}
