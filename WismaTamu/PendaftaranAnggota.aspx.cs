using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WismaTamu.Pengendali;
using WismaTamu.Sistem;
using WismaTamu.Model;
using System.IO;

namespace WismaTamu
{
    public partial class PendaftaranAnggota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnProses_Click(object sender, EventArgs e)
        {
            if (cbSetuju.Checked)
            {
                Anggota dataAnggotaBaru = new Anggota();
                dataAnggotaBaru.IdAnggota = tbIdentitas.Text;
                dataAnggotaBaru.NamaAnggota = tbNama.Text;
                dataAnggotaBaru.AlamatAnggota = tbAlamat.Text;
                dataAnggotaBaru.NomorKontakAnggota = tbKontak.Text;
                dataAnggotaBaru.PasswordAnggota = tbSandi.Text;
                dataAnggotaBaru.SurelAnggota = tbSurel.Text;
                PengendaliDataAnggota.TambahAnggotaBaru(dataAnggotaBaru);
                tbIdentitas.Text = "";
                tbNama.Text = "";
                tbAlamat.Text = "";
                tbKontak.Text = "";
                tbSandi.Text = "";
                tbKonfSandi.Text = "";
                tbSurel.Text = "";
                Response.Write("<script>alert(\"Pendaftaran Berhasil!\");</script>");
                Response.AddHeader("REFRESH", "1;URL=Default.aspx");
                //Response.Redirect("~/Default.aspx");
            }
        }
    }
}