using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WismaTamu.Model;

namespace WismaTamu
{
    public partial class ManageMember : System.Web.UI.Page
    {
        private WismaTamuContext db =
 new WismaTamuContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            var data = (from n in db.Members select n);
            GridView1.DataSource = data.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Member newMember = new Member { MemberId = Int16.Parse(txtIdMember.Text), NamaMember = txtNamaMember.Text, AlamatMember = txtAlamatMember.Text };
            db.Members.Add(newMember);
            db.SaveChanges();

            // Karena Page_Load hanya dipanggil pada saat halaman "pertama kali" dibuka
            Response.Redirect("ManageMember.aspx");
        }

        public override void Dispose()
        {
            base.Dispose();
            db.Dispose();
        }
        
    }
}