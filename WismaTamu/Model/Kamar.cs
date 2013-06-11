using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    public class Kamar
    {
        [Required(ErrorMessage="Id Kamar Belum Ditentukan")]
        [Key]
        public int IdKamar { get; set; }

        [Required(ErrorMessage = "Harga Sewa Kamar Belum Ditentukan")]
        public double HargaPerMalam { get; set; }

        [Required(ErrorMessage = "Jenis Kamar Belum Ditentukan")]
        public int JenisKamar { get; set; }

        [Required(ErrorMessage = "Ketersediaan Kamar Belum Ditentukan")]
        public bool KamarTersedia { get; set; }

        [Required(ErrorMessage = "Kapasitas Kamar Belum Ditentukan")]
        public int KapasitasKamar { get; set; }

        [Required(ErrorMessage = "Nama Kamar Belum Ditentukan")]
        public string NamaKamar { get; set; }

        [Required(ErrorMessage = "Wisma Kamar Belum Ditentukan")]
        public int Wisma { get; set; }

        public Kamar()
        {
            KamarTersedia = true;
        }
    }
}