using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        public string studentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime birthDay { get; set; }
        public string Countryside { get; set; }
    }
} 