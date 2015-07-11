using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Scrawl.Models
{
    public class SchoolModel
    {
        public string Name { get; set; }
        // TODO: Add some sort of location service info here
    }
}