using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WismaTamu.Pengendali;
using WismaTamu.Sistem;

namespace WismaTamu
{
    public partial class Checkin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblTanggal.Text = DateTime.Now.ToString();
                //grid.DataSource = PengendaliDataPesanan.LihatPesananCheckinHariIni().ToList();
                repeater1.DataSource = PengendaliDataAnggota.LihatSemuaAnggota().ToList();
                repeater1.DataBind();
            }
        }
        protected void btCari_Click(object sender, EventArgs e)
        {
            repeater1.DataSource = PengendaliDataPesanan.LihatPesananKode(Int16.Parse(tbCari.Text));
            repeater1.DataBind();
        }

        protected void btnDetail_Click(object sender, EventArgs e)
        {
        }

        protected void btnCheckin_Click(object sender, EventArgs e)
        {
        }

        protected void btnCheckinDetail_Click(object sender, EventArgs e)
        {
        }

        /*protected void btnDetail_Click(object sender, EventArgs e)
        {
        }*/
    }
}