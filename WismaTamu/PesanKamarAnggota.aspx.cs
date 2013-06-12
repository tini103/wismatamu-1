using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WismaTamu.Model;

namespace WismaTamu
{
    public partial class PesanKamarAnggota : System.Web.UI.Page
    {
        private WismaTamuDb db = new WismaTamuDb();

        protected void Page_Load(object sender, EventArgs e)
        {
            var lala = db.Petugas.ToList();
            listKamarPlaceholder.Visible = false;
        }


        protected void btnCariKamar_Click(object sender, EventArgs e)
        {
            listKamarPlaceholder.Visible = true;
        }
    }
}