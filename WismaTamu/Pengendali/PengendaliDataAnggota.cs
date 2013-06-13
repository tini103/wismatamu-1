using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WismaTamu.Model;
using WismaTamu.Sistem;

namespace WismaTamu.Pengendali
{
    public static class PengendaliDataAnggota
    {
        private static WismaTamuDb db = new WismaTamuDb();

        public static List<Anggota> LihatSemuaAnggota()
        {
            return db.Anggota.ToList();
        }

        public static Anggota SuntingDataAngota(string idAnggota)
        {
            return db.Anggota.SingleOrDefault(x => x.IdAnggota == idAnggota);
        }

        public static void TambahAnggotaBaru(Anggota dataAnggotaBaru)
        {
            
            db.Anggota.Add(dataAnggotaBaru);
            db.SaveChanges();
        }
    
        public static bool CekAnggota(string idPengguna,string kataSandiMD5)
        {
 	        // Cek data anggota apakah ada atau tidak
            kataSandiMD5 = Md5Helper.KonversiKeMd5(kataSandiMD5);
            var dataAnggota = db.Anggota.Where(x => x.IdAnggota == idPengguna && x.PasswordAnggota == kataSandiMD5);
            if (dataAnggota.Count() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Anggota AmbilAnggota(string idPengguna)
        {
            return db.Anggota.SingleOrDefault(x => x.IdAnggota == idPengguna);
        }
    }
}