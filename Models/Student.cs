using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string studentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime birthDay { get; set; }
        public string Countryside { get; set; }
    }
}