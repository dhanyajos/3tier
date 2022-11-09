using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Newproj.student
{
    public partial class StudentReg : System.Web.UI.Page
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
            objdptbl.studname = TextBox1.Text;
            objdptbl.studemail = TextBox2.Text;
            objdptbl.studphone = TextBox3.Text;



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
            objdptbl.studgender = gender;
            string dob = Ddlday.SelectedValue + "/" + Ddlmonth.SelectedValue + "/" + Ddlyear.SelectedValue;
            objdptbl.studdob = dob;
            objdptbl.studcourse = ddlcourse.SelectedValue;
            objdptbl.studusername = TextBox4.Text;
            objdptbl.studpasswd = TextBox5.Text;
            object ob = objdptbl.stud_login_insert();
            objdptbl.id = ob;
            int j = objdptbl.student_reg();
            Response.Redirect("../Guest/Firstform.aspx");
            Response.Write("Your Registration is successful");
        }
        }
}