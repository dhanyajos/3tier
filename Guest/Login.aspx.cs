using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Newproj.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        BAL.RegBAL objdptbl = new BAL.RegBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdptbl.username = TextBox1.Text;
            objdptbl.password = TextBox2.Text;

            int i = objdptbl.userlogin();
            if(i>0)
            {
                Response.Redirect("userhome.aspx");
            }
            else
            {
                Response.Write("Invalid");
            }
           
        }
    }
}