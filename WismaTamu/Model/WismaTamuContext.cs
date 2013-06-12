using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    // Kelas context contoh
    // Untuk implementasi, gunakan kelas WismaTamuDb
    public class WismaTamuContext: DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}