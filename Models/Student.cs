using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string studentName { get; set; }

        [Display(Name = "birthDay")]
        [DataType(DataType.Date)]
        public DateTime birthDay { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Countryside { get; set; }

        // [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        // [StringLength(5)]
        // [Required]
        // public string Rating { get; set; }
    }
} 