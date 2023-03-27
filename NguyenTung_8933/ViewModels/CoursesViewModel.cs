using NguyenTung_8933.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenTung_8933.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}