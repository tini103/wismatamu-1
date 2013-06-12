using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WismaTamu.Pengendali;

namespace WismaTamu.View
{
    public partial class KelolaDataKamar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DetilKamarPlaceHolder.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //PengedaliKamar pk = new PengedaliKamar();
            string wisma = DropDownList1.SelectedValue.ToString();
            if (wisma == "Wisma Yasmin")
                PengendaliKamar.LihatSemuaKamar(1);
            else if(wisma == "Wisma Flamboyan")
                PengendaliKamar.LihatSemuaKamar(2);
            else if(wisma == "Wisma Bougenvile")
                PengendaliKamar.LihatSemuaKamar(3);

            

            DetilKamarPlaceHolder.Visible = true;
        }


    
    }
}