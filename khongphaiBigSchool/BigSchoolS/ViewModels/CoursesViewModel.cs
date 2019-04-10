using BigSchoolS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchoolS.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> upcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}