using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    // PERINGATAN!
    // Kelas ini hanyalah kelas contoh sebagai referensi, jangan gunakan kelas ini untuk aplikasi jadi.
    // -- Wira

    public class Member
    {
        [Required]
        public int MemberId { get; set; }

        [Required]
        public string NamaMember { get; set; }

        [Required]
        public string AlamatMember { get; set; }
    }
}