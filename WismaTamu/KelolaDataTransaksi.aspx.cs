using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WismaTamu.Model;
using WismaTamu.Pengendali;

namespace WismaTamu
{
    public partial class KelolaDataTransaksi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var data = PengendaliDataPesanan.Cari(idMember.Text, DateTime.Parse(tglPesanan.Text));
            rpt.DataSource = data.ToList();
            rpt.DataBind();
        }
    }
}