using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    public class Anggota
    {
        [Required(ErrorMessage = "Id Anggota belum ditentukan")]
        [Key]
        public string IdAnggota { get; set; }
        
        [Required(ErrorMessage = "Alamat Anggota belum ditentukan")]
        public string AlamatAnggota { get; set; }
        
        [Required(ErrorMessage = "Nama Anggota belum ditentukan")]
        public string NamaAnggota { get; set; }
        
        [Required(ErrorMessage = "Nomor Kontak Anggota belum ditentukan")]
        public string NomorKontakAnggota { get; set; }
        
        [Required(ErrorMessage = "Password Anggota belum ditentukan")]
        public string PasswordAnggota { get; set; }
        
        [Required(ErrorMessage = "Alamat Surel Anggota belum ditentukan")]
        public string SurelAnggota { get; set; }
    }
}