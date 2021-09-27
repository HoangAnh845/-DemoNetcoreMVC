using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DemoMVC.Models
{
    public class MovieGenreViewModel
    {
        public List<Student> Student { get; set; }
        public SelectList studentName { get; set; }
        public string STstudentName  { get; set; }
        public string SearchString { get; set; }
    }
}