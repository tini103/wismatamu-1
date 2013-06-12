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
        private WismaTamuDb db = new WismaTamuDb();
        protected void Page_Load(object sender, EventArgs e)
        {
            //aku g tau load repeaternya
            var meong = db.Pesanan.ToString();
            listDataTransaksi.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // ini ada carinya tapi masukin repeaternya g tau
            PengendaliDataPesanan.Cari(TextBox1.Text, tanggalPesan.Text);
            listDataTransaksi.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //ini cari yang klo dah dikonfirmasi tapi g tau gmn munculin ke repeater
            var dataPesanan = PengendaliDataPesanan.Cari(TextBox1.Text, tanggalPesan.Text);

            if(dataPesanan.BuktiTransfer!="")
            {
                rptTransaksi.DataSource = dataPesanan;
                rptTransaksi.DataBind();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //aku g tau cara implementasinya kluar detilnya itu apa aja soalnya kn mnurutku yang dikeluarkan itu sdh merupakan detil transaksi
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //kalo status pembayaran -2 itu brarti data udah terbuang dan g bs diliat lg aku ngesetnya kurang tau
            var dataPesanan = PengendaliDataPesanan.Cari(TextBox1.Text, tanggalPesan.Text);
            dataPesanan.StatusPembayaran = -2;
        }
    }
}