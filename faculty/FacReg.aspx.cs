using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Newproj.faculty
{
   
    public partial class FacReg : System.Web.UI.Page
    {
        BAL.RegBAL objdptbl = new BAL.RegBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                Ddlday.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                Ddlmonth.Items.Add(i.ToString());
            }

            for (int i = 1998; i <= DateTime.Now.Year; i++)
            {
                Ddlyear.Items.Add(i.ToString());
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdptbl.facname = TextBox1.Text;
            objdptbl.facemail = TextBox2.Text;
            objdptbl.facphone = TextBox3.Text;

            string gender = string.Empty;
            if (RadioButton1.Checked)
            {
                gender = "Male";
            }
            else if (RadioButton2.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Others";
            }
            objdptbl.facgender = gender;
            string dob = Ddlday.SelectedValue + "/" + Ddlmonth.SelectedValue + "/" + Ddlyear.SelectedValue;
            objdptbl.facdob = dob;
            objdptbl.faccollege = ddlcollege.SelectedValue;
            objdptbl.facusername = TextBox4.Text;
            objdptbl.facpasswd = TextBox5.Text;
            object ob = objdptbl.fac_login_insert();
            objdptbl.facob = ob;
            int j = objdptbl.fac_reg();
            Response.Redirect("../Guest/Firstform.aspx");
            Response.Write("Your Registration is successful");
        }
    }
}