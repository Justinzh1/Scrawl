using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Scrawl.Models
{
    public class TeacherModel
    {
        public string Name { get; set; }
        public string School { get; set; }
        public CourseModel[] Courses { get; set; }  
    }
}