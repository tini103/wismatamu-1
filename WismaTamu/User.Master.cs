using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WismaTamu.Pengendali;

namespace WismaTamu
{
    public partial class MasterUtama : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Cek pengguna apakah dia sudah masuk atau belum
            if (PengendaliSesi.IsLogin())
            {
                userInfoPlaceholder.Visible = true;
                loginPlaceholder.Visible = false;
            }
            else
            {
                userInfoPlaceholder.Visible = false;
                loginPlaceholder.Visible = true;
            }

            // Define event handler for button
            btnLogin.Click += btnLogin_Click;
            btnDaftar.Click += btnDaftar_Click;  
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnLogin_Click(object sender, EventArgs e)
        {
            // Lakukan proses login
            bool hasilLogin = PengendaliSesi.LakukanLogin(txtUserName.Text, txtPassword.Text);
            if (hasilLogin == true)
            {
                Response.Redirect("/Default.aspx");

            }
            else
            {
                // Tampilkan pesan kesalahan login dalam jQuery (mungkin)
                // Belum terimplementasi sempurna
                Response.Redirect("/Default.aspx");
            }
        }

        
    }
}