using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Scrawl.Models
{
    public class NotebookModel
    {
        public int ID { get; set; }
    }
    public class NotebookDBContext : DbContext
    {
        public DbSet<NotebookModel> Notebooks { get; set; }

        public System.Data.Entity.DbSet<Scrawl.Models.CourseModel> CourseModels { get; set; }
    }
}