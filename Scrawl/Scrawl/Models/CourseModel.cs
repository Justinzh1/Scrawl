using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Scrawl.Models
{
    public class CourseModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public TeacherModel Teacher { get; set; }
        public SchoolModel School { get; set; }
    }
    public class CourseDBContext : DbContext
    {
        public DbSet<CourseModel> Users { get; set; }
    }
}