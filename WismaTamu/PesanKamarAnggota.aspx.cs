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
    public partial class PesanKamarAnggota : System.Web.UI.Page
    {
        private WismaTamuDb db = new WismaTamuDb();
        private List<Kamar> kamarTersedia = new List<Kamar>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listKamarPlaceholder.Visible = false;
            }
            
        }
        


        protected void btnCariKamar_Click(object sender, EventArgs e)
        {
            // Lakukan pencarian data kamar yang tersedia
           
            try
            {
                DateTime tanggalCheckIn = DateTime.Parse(tglCheckIn.Text);
                DateTime tanggalCheckOut = DateTime.Parse(tglCheckOut.Text);

                //var kamarTersedia = PengendaliDataPesanan.CekPesananRentangTanggal(tanggalCheckIn, tanggalCheckOut).ToList();
                // Mocking object testing
                
                kamarTersedia.Add(new Kamar { HargaPerMalam = 200000, JenisKamar = 1, NamaKamar = "Kamar 1", Wisma = 0, KapasitasKamar = 2, IdKamar = 1, KamarTersedia = true });
                kamarTersedia.Add(new Kamar { HargaPerMalam = 200000, JenisKamar = 1, NamaKamar = "Kamar 2", Wisma = 0, KapasitasKamar = 2, IdKamar = 2, KamarTersedia = true });
                kamarTersedia.Add(new Kamar { HargaPerMalam = 200000, JenisKamar = 1, NamaKamar = "Kamar 3", Wisma = 0, KapasitasKamar = 2, IdKamar = 3, KamarTersedia = true });


                if (kamarTersedia.Count > 0)
                {
                    listKamarPlaceholder.Visible = true;
                    rptKamar.DataSource = kamarTersedia;
                    rptKamar.DataBind();
                    lblStatus.Visible = false;

                }
                else
                {
                    lblStatus.Visible = true;
                    lblStatus.Text = "Maaf! Kamar pada tanggal tersebut tidak ditemukan";
                }

            }
            catch (Exception)
            {

            }
            
        }

        public void chkKamarDipilih_CheckedChanged(object sender, EventArgs e)
        {
            double hargaTotal = 0.0; 
            foreach (RepeaterItem item in rptKamar.Items)
            {
                // Cek setiap checkbox, dan hitung harga totalnya
                CheckBox chk = (CheckBox) item.FindControl("chkKamarDipilih");

                hargaTotal += kamarTersedia[Int16.Parse(chk.Text)].HargaPerMalam;
            }
        }
    }
}