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

        // Variabel untuk view sate
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listKamarPlaceholder.Visible = false;
                setujuPesananPlaceholder.Visible = false;
                btnPesan.Visible = false;
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
                /*
                kamarTersedia.Add(new Kamar { HargaPerMalam = 200000, JenisKamar = 1, NamaKamar = "Kamar 1", Wisma = 0, KapasitasKamar = 2, IdKamar = 1, KamarTersedia = true });
                kamarTersedia.Add(new Kamar { HargaPerMalam = 200000, JenisKamar = 1, NamaKamar = "Kamar 2", Wisma = 0, KapasitasKamar = 2, IdKamar = 2, KamarTersedia = true });
                kamarTersedia.Add(new Kamar { HargaPerMalam = 200000, JenisKamar = 1, NamaKamar = "Kamar 3", Wisma = 0, KapasitasKamar = 2, IdKamar = 3, KamarTersedia = true });
                */
                kamarTersedia.AddRange(PengendaliDataPesanan.CekPesananRentangTanggal(tanggalCheckIn, tanggalCheckOut));

                if (kamarTersedia.Count > 0)
                {
                    listKamarPlaceholder.Visible = true;
                    rptKamar.DataSource = kamarTersedia;
                    rptKamar.DataBind();
                    lblStatus.Visible = false;
                    setujuPesananPlaceholder.Visible = true;
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
            int countChecked = 0;
            foreach (RepeaterItem item in rptKamar.Items)
            {
                // Cek setiap checkbox, dan hitung harga totalnya
                CheckBox chk = (CheckBox)item.FindControl("chkKamarDipilih");
                Label lbl = (Label)item.FindControl("lblHargaPerItem");

                if (chk.Checked == true)
                {
                    hargaTotal += Double.Parse(lbl.Text);
                    countChecked += 1;
                }
            }

            if (countChecked > 0)
            {
                btnPesan.Visible = true;
            }
            else
            {
                btnPesan.Visible = false;
            }

            hargaTotal *= ((TimeSpan)ViewState["selisihTanggal"]).Days;
            ViewState["hargaTotal"] = hargaTotal;

            lblTotalHarga.Text = "Rp. " + hargaTotal.ToString();
        }

        protected void rptKamar_ItemCreated(object sender, RepeaterItemEventArgs e)
        {
            // Async Postback Register for Checkbox
            // Not implemented yet
            //var control = e.Item.FindControl("chkKamarDipilih");
            //AsyncPostBackTrigger controlAsync = new AsyncPostBackTrigger();
            //controlAsync.ControlID = control;

        }

        protected void btnPesan_Click(object sender, EventArgs e)
        {
            // Lakukan proses pemesanan secara langsung
            // Buat list kamar yang dipesan
            List<Kamar> kamarDipesan = new List<Kamar>();

            foreach (RepeaterItem item in rptKamar.Items)
            {
                // Cek setiap checkbox, dan hitung harga totalnya
                CheckBox chk = (CheckBox)item.FindControl("chkKamarDipilih");

                if (chk.Checked == true)
                {
                    kamarDipesan.Add(PengendaliKamar.AmbilKamar(Int16.Parse(chk.Text)));
                }
            }

            // Buat data pesanan
            Pesanan newPesanan = new Pesanan
            {
                TanggalCheckin = DateTime.Parse(tglCheckIn.Text),
                TanggalCheckout = DateTime.Parse(tglCheckOut.Text),
                TanggalBayarDpMaks = DateTime.Now.AddDays(5),   // Bawaan maksimal 3 hari untuk sementara
                StatusPembayaran = 0,
                StatusPenginapan = 0,
                AnggotaPemesanId = PengendaliSesi.GetIdPengguna(),
                BiayaPemesanan = (double) ViewState["hargaTotal"],
                BiayaPiutang = (double)ViewState["hargaTotal"],
            };

            // Proses pemesanan, ambil id nya
            // Nunggu commit dari Indra untuk implementasi pasti dari TambahPesananBaru
            int idPesanan = PengendaliDataPesanan.TambahPesananBaru(newPesanan, kamarDipesan);


            // Tampilkan tanda jadi pesanan
            listKamarPlaceholder.Visible = false;
            btnCariKamar.Visible = false;
            pilihTanggalPlaceholder.Visible = false;
            hasilPesanan.Visible = true;


            // Tampilkan isi data-datanya
            nmrPesanan.Text = idPesanan.ToString();
            namaPemesan.Text = PengendaliDataAnggota.AmbilAnggota(newPesanan.AnggotaPemesanId).NamaAnggota;
            alamatPemesan.Text = PengendaliDataAnggota.AmbilAnggota(newPesanan.AnggotaPemesanId).AlamatAnggota;
            listKamarDipesan.Items.Clear();

            foreach (Kamar kamar in kamarDipesan)
            {
                listKamarDipesan.Items.Add(new ListItem { Text = kamar.NamaKamar });
            }


        }

        protected void tglCheckIn_TextChanged(object sender, EventArgs e)
        {
            listKamarPlaceholder.Visible = false;
            TimeSpan selisihTanggal = DateTime.Parse(tglCheckOut.Text) - DateTime.Parse(tglCheckIn.Text);
            ViewState["selisihTanggal"] = selisihTanggal;

        }

        protected void tglCheckOut_TextChanged(object sender, EventArgs e)
        {
            listKamarPlaceholder.Visible = false;
            TimeSpan selisihTanggal = DateTime.Parse(tglCheckOut.Text) - DateTime.Parse(tglCheckIn.Text);
            ViewState["selisihTanggal"] = selisihTanggal;
        }
    }
}