using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    public class PesananKamar
    {
        [Required]
        [Key]
        public int IdPesananKamar { get; set; }

        [Required]
        public int IdPesanan { get; set; }

        //[Required]
        [ForeignKey("IdPesanan")]
        public virtual Pesanan Pesanan { get; set; }

        [Required]
        public int IdKamar { get; set; }

        //[Required]
        [ForeignKey("IdKamar")]
        public virtual Kamar Kamar { get; set; }
    }
}