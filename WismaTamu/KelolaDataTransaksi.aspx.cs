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
            var data = PengendaliDataPesanan.Cari(idMember.Text);
            rpt.DataSource = data.ToList();
            rpt.DataBind();
        }

        protected void rpt_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            
            switch (e.CommandName)
            {
                case "Setujui":
                    PengendaliDataPesanan.SetujuiPesanan(Int16.Parse(e.CommandArgument.ToString()));
                    break;
                case "Batalkan":
                    PengendaliDataPesanan.BatalkanPesanan(Int16.Parse(e.CommandArgument.ToString()));
                    break;
            }

            rpt.DataBind();
            
        }
    }
}