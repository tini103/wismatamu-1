using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WismaTamu.Model;
using WismaTamu.Sistem;

namespace WismaTamu.Pengendali
{
    public static class PengendaliPetugas
    {
        // Jika kelas pengendali butuh basis data, instansiasi terlebih dahulu basis datanya
        private static WismaTamuDb db = new WismaTamuDb();
        public static bool CekPetugas(string idPetugas, string kataSandiMD5)
        {
            kataSandiMD5 = Md5Helper.KonversiKeMd5(kataSandiMD5);

            if((db.Petugas.Where(x => x.NamaAkun == idPetugas && x.SandiMasuk == kataSandiMD5).Count() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}