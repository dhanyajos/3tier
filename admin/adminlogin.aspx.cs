using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Newproj.admin
{
    public partial class adminlogin : System.Web.UI.Page
    {
        BAL.RegBAL objdptbl = new BAL.RegBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
           
                if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
                {
                     Response.Redirect("adminhome.aspx");
                }
                else
                {
                    Response.Write("Invalid credentials");
                }
            
            
        }
    }
}