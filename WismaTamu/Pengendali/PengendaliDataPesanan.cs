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

        public static void CekPesananRentangTanggal(DateTime tanggalCheckin, DateTime tanggalCheckout)
        {
            List<Pesanan> listPesanan = new List<Pesanan>();
            foreach (var pesanan in db.Pesanan.Where(x => tanggalCheckin < x.TanggalCheckin && tanggalCheckout > x.TanggalCheckout && x.StatusPembayaran > 0))
            {
                listPesanan.Add(pesanan);
            }
            HasilPesananKamar(listPesanan);
        }

        public static List<Kamar> HasilPesananKamar(List<Pesanan> listPesanan)
        {
            List<Kamar> listPesananKamar = new List<Kamar>();
            foreach (var pesananKamar in listPesanan)
            {
                listPesananKamar.Add(pesananKamar.KamarDipesan.Kamar);
            }
            return listPesananKamar;
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
        }
    }
}