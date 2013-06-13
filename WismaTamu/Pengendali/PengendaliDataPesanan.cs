using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            foreach (var pesanan in db.Pesanan.Where(x => ((tanggalCheckin <= x.TanggalCheckin && tanggalCheckout >= x.TanggalCheckout) || (tanggalCheckin <= x.TanggalCheckout && x.TanggalCheckin <= tanggalCheckin ) || (x.TanggalCheckin <= tanggalCheckout && tanggalCheckout <= x.TanggalCheckout)) && x.StatusPembayaran > 0))
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

        public static int TambahPesananBaru(Pesanan dataPesananBaru, List<Kamar> listKamar)
        {
            dataPesananBaru.StatusPembayaran = 0;
            foreach(var pesanan in db.Pesanan.Where(x=> x.StatusPembayaran == -1))
            {
                var pesananBelumFix = db.PesananKamar.Where(x => x.IdPesanan == pesanan.IdPesanan);
                foreach (PesananKamar pesaananKamar in pesananBelumFix)
                {
                    foreach (Kamar kamar in listKamar)
                    {
                        if (kamar == pesaananKamar.Kamar)
                        {
                            dataPesananBaru.StatusPembayaran = -1;
                        }
                    }
                }
            }


            
            db.Pesanan.Add(dataPesananBaru);
            db.SaveChanges();
          
           
            foreach (Kamar kamar in listKamar)
            {
                db.PesananKamar.Add(new PesananKamar { IdPesanan = dataPesananBaru.IdPesanan, IdKamar = kamar.IdKamar });
            }
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

            }
            return dataPesananBaru.IdPesanan;
        }

        public static List<Pesanan> Cari(string idAnggota)
        {
            return db.Pesanan.Where(
                        x => x.AnggotaPemesanId == idAnggota && x.StatusPembayaran == 0).ToList();
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

        public static void SetujuiPesanan(int idPesanan)
        {
            db.Pesanan.SingleOrDefault(x => x.IdPesanan == idPesanan).StatusPembayaran = 1;
        }

        public static void BatalkanPesanan(int idPesanan)
        {
            db.Pesanan.SingleOrDefault(x => x.IdPesanan == idPesanan).StatusPembayaran = 1;
        }
    }
}