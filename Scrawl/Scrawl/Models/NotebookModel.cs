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
        public UserModel user { get; set; } // TODO: Automatically set to user that's currently logged in
    }
    public class NotebookDBContext : DbContext
    {
        public DbSet<NotebookModel> Notebooks { get; set; }
    }
}