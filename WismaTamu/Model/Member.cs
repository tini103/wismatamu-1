using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
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