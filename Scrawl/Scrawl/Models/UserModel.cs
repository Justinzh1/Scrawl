using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Scrawl.Models
{
    [Table("UserDetails")]
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public string Email { get; set; }
        public bool IsStudent { get; set; }
        public string SchoolName { get; set; } // TODO: Create SchoolObject class
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class UserDBContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
    }
}