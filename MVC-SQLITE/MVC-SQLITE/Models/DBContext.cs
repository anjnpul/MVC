using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_SQLITE.Models
{
    public class DBContext: DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<DATA> DATAs { get; set; }
    }
}