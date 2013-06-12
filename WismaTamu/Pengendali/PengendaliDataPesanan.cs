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

        public static List<Pesanan> CekPesananRentangTanggal(DateTime tanggalCheckin, DateTime tanggalCheckout)
        {
            List<Pesanan> listPesanan = new List<Pesanan>();
            foreach (var x in db.Pesanan.Where(x => x.TanggalCheckin >= tanggalCheckin && x.TanggalCheckout <= tanggalCheckout && x.StatusPembayaran > 0))
            {
                listPesanan.Add(x);
            }
            return listPesanan;
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