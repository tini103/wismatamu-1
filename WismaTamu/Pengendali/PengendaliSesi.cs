using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WismaTamu.Pengendali
{
    // Jangan lupa kelas pengendali merupakan kelas statik
    public static class PengendaliSesi
    {
        public static bool LakukanLogin(string idPengguna, string kataSandiMD5)
        {
            if (PengendaliPetugas.CekPetugas(idPengguna, kataSandiMD5))
            {
                HttpContext.Current.Session["idPengguna"] = idPengguna;
                HttpContext.Current.Session["role"] = 0;

                return true;
            }


            // Uncomment jika kelas PengendaliAnggota sudah diimplementasikan
            //if(PengendaliiAnggota->CekAnggota(idPengguna, kataSandiMD5)
            //{
            //    HttpContext.Current.Session["idPengguna"] = idPengguna;
            //    HttpContext.Current.Session["role"] = 1;
            //
            //    return true;
            //}

            return false;
            
        }

        public static bool IsLogin()
        {
            if (HttpContext.Current.Session["idPengguna"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetIdPengguna()
        {
            if (HttpContext.Current.Session["idPengguna"] != null)
            {
                return HttpContext.Current.Session["idPengguna"].ToString();
            }
            else
            {
                return null;
            }
        }

        public static int GetRolePengguna()
        {
            if (HttpContext.Current.Session["role"] != null)
            {
                return (int) HttpContext.Current.Session["role"];
            }
            else
            {
                return 1;
            }
        }

        public static bool LakukanLogout()
        {
            HttpContext.Current.Session.RemoveAll();
            HttpContext.Current.Session.Abandon();

            if (HttpContext.Current.Session["idPengguna"] == null)
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