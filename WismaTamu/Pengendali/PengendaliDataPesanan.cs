using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WismaTamu.Model;
using WismaTamu.Sistem;

namespace WismaTamu.Pengendali
{
    public static class PengendaliDataPesanan
    {
        private static WismaTamuDb db = new WismaTamuDb();

        public static List<Kamar> CekPesananRentangTanggal(DateTime tanggalCheckin, DateTime tanggalCheckout)
        {
            List<Kamar> listKamarDilarangDipesan = new List<Kamar>();

            // Cek 
            foreach (var pesanan in db.Pesanan.Where(x => tanggalCheckin < x.TanggalCheckin && tanggalCheckout > x.TanggalCheckout && x.StatusPembayaran > 0))
            {
                // Ambil kamar dipesan untuk pesanan tersebut
                var kamarDipesan = db.PesananKamar.Where(x => x.IdPesanan == pesanan.IdPesanan);
                foreach (PesananKamar pesananKamar in kamarDipesan)
                {
                    Kamar kamarDilarang = pesananKamar.Kamar;
                    if (listKamarDilarangDipesan.Where(x => x.Equals(kamarDilarang)).Count() == 0)
                    {
                        listKamarDilarangDipesan.Add(kamarDilarang);
                    }
                }
            }

            // Ambil kamar yang tidak termasuk didalam daftar kamar dilarang
            List<Kamar> listKamar = new List<Kamar>();
            var dataKamar = db.Kamar.Where(x => x.KamarTersedia == true);
            foreach (Kamar kamar in dataKamar)
            {
                if (listKamarDilarangDipesan.Where(x => x.Equals(kamar)).Count() == 0)
                {
                    listKamar.Add(kamar);
                }
            }

            return listKamar;
        }

      
       
        public static bool CekStatusKamarDipilih(int inputID)
        {
            var kamar = db.Kamar.SingleOrDefault(x => x.IdKamar == inputID);
            return kamar.KamarTersedia;
        }

        public static void CheckinPesanan(int inputID)
        {
            var pesanan = db.Pesanan.SingleOrDefault(x => x.IdPesanan == inputID);
            pesanan.StatusPenginapan = 1;
        }

        public static void CheckoutPesanan(int inputID)
        {
            var pesanan = db.Pesanan.SingleOrDefault(x => x.IdPesanan == inputID);
            pesanan.StatusPenginapan = 2;
        }

        public static void EditPesananMember(int inputID, Pesanan dataPesananBaru)
        {
            var pesanan = db.Pesanan.SingleOrDefault(x => x.IdPesanan == inputID);
            pesanan = dataPesananBaru;
        }

        public static List<Pesanan> LihatPesananCheckinHariIni()
        {
            List<Pesanan> listPesanan = new List<Pesanan>();
            foreach (var pesanan in db.Pesanan.Where(x => x.TanggalCheckin == DateTime.Now))
            {
                listPesanan.Add(pesanan);
            }
            return listPesanan;
        }

        public static List<Pesanan> LihatPesananCheckoutHariIni()
        {
            List<Pesanan> listPesanan = new List<Pesanan>();
            foreach (var pesanan in db.Pesanan.Where(x => x.TanggalCheckout == DateTime.Now))
            {
                listPesanan.Add(pesanan);
            }
            return listPesanan;
        }

        public static Pesanan LihatPesananKode(int inputID)
        {
            return db.Pesanan.SingleOrDefault(x => x.IdPesanan == inputID);
        }

        public static List<Pesanan> LihatPesananMember(string idAnggota)
        {
            List<Pesanan> listPesanan = new List<Pesanan>();
            foreach (var pesanan in db.Pesanan.Where(x => x.AnggotaPemesanId == idAnggota))
            {
                listPesanan.Add(pesanan);
            }
            return listPesanan;
        }

        public static void TambahPesananBaru(Pesanan dataPesananBaru)
        {
            db.Pesanan.Add(dataPesananBaru);
            db.SaveChanges();
        }

        public static Pesanan Cari(string idAnggota, string tgl)
        {
            return db.Pesanan.SingleOrDefault(
                        x => x.AnggotaPemesanId == idAnggota && x.TanggalCheckin.ToString() == tgl);
        }

        public static int SetBuktiPembayaran(string idAnggota)
        {
            var data = db.Pesanan.SingleOrDefault(
                           x => x.AnggotaPemesanId == idAnggota);

            if (data.BuktiTransfer != "")
            {
                return 1;
            }
            else
                return 0;
        }
    }
}