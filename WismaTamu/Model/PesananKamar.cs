using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    public class PesananKamar
    {
        [Required]
        public int IdPesananKamar { get; set; }

        [Required]
        public int IdPesanan { get; set; }

        [Required]
        public Pesanan Pesanan { get; set; }

        [Required]
        public int IdKamar { get; set; }

        [Required]
        public Kamar Kamar { get; set; }
    }
}