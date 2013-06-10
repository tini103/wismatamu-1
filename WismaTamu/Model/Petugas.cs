using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    public class Petugas
    {
        [Required]
        public int PetugasId { get; set; }

        [Required(ErrorMessage="Nama lengkap belum diisi")]
        public string NamaLengkap { get; set; }

        [Required(ErrorMessage="Nama akun belum diisi")]
        [Key]
        public string NamaAkun { get; set; }

        [Required(ErrorMessage="Sandi Masuk belum diisi")]
        public string SandiMasuk { get; set; }

        [Required]
        public bool Aktif { get; set; }

        // Inisiasi data bawaan
        public Petugas()
        {
            Aktif = false;
        }
    }
}