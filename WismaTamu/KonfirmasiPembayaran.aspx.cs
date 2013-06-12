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
    public partial class KonfirmasiPembayaran : System.Web.UI.Page
    {
        private WismaTamuDb db = new WismaTamuDb();
        protected void Page_Load(object sender, EventArgs e)
        {
            var meong = db.Pesanan.ToString();
            listDataTransaksi.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //itu di set bukti parsing is anggota yang login tp caranya gmn aku g tau;
            int dataPesanan = PengendaliDataPesanan.SetBuktiPembayaran("");

            if (dataPesanan == 1)
            {
                //maunya messagebox.show tapi aku g tau caranya
            }
            
            //dataPesan.SetBuktiPembayaranPemesnan();
            //MessageBox.Show();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //aku g tau cara implementasinya kluar detilnya itu apa aja soalnya kn mnurutku yang dikeluarkan itu sdh merupakan detil transaksi
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //itu di set bukti parsing is anggota yang login tp caranya gmn aku g tau;
            var dataPesanan = PengendaliDataPesanan.LihatPesananMember("").SingleOrDefault();
            dataPesanan.StatusPembayaran = -2;
            //var dataPesanan = PengendaliDataPesanan.Cari(TextBox1.Text, tanggalPesan.Text);
            //dataPesanan.StatusPembayaran = -2;
        }
    }
}