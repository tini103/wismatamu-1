using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    public class WismaTamuContext: DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}