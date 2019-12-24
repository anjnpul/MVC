using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TEST.Models
{
    public class DBClass: DbContext
    {
        public DbSet<user> users { get; set; }
    }
}