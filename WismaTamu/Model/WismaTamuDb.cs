using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    public class WismaTamuDb: DbContext
    {
        // Masukkan kelas entitas sebagai tabel disini
        public DbSet<Petugas> Petugas { get; set; }
    }
}