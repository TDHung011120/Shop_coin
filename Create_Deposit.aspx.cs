using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test2_TrinhDinhHung
{
    public partial class Create_Deposit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int usd = int.Parse(txtUSD.Text);
            int vnd = usd * 24000;
            lbVND.Text=vnd.ToString("#,##0 đ");
        }
    }
}