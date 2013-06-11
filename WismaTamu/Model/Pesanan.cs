using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    public class Pesanan
    {
        [Required(ErrorMessage="Nomor identitas pesanan belum diisi")]
        [Key]
        public int IdPesanan { get; set; }

        [Required(ErrorMessage="Anggota pemesan belum ditentukan")]
        public int AnggotaPemesanId { get; set; }

        // Hilangkan komentar jika kelas Anggota sudah diimplementasikan
        //[ForeignKey("AnggotaPemesanId")]
        //public virtual Anggota AnggotaPemesan { get; set; }

        [Required]
        public int KamarDipesanId { get; set; }

        // Mongo lanjutnya Indra
        

    }
}