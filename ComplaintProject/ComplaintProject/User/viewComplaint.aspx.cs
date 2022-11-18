using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintProject.User
{
    public partial class viewComplaint : System.Web.UI.Page
    {
        BAL.CmpBAL objdptbl = new BAL.CmpBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objdptbl.userViewComplaint();
                GridView1.DataBind();
            }
        }
    }
}