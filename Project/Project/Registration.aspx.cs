using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Registration : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "User")
            {
                Response.Redirect("User.aspx");
            }
            else if(DropDownList1.SelectedItem.Text == "Admin")
            {
                Response.Redirect("Admin.aspx");
            }
                       

            
        }
    }
}