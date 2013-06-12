using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WismaTamu.Sistem
{
    public static class Md5Helper
    {
        public static string KonversiKeMd5(string input)
        {
            string hash;

            using (MD5 md5Hash = MD5.Create())
            {
                hash = GetMd5Hash(md5Hash, input);
                
            }
            return hash;
        }

        // Fungsi internal untuk konversi string
        // http://msdn.microsoft.com/en-us/library/system.security.cryptography.md5.aspx

        private static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
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