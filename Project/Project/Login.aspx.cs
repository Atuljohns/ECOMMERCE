using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Login : System.Web.UI.Page
    {
        Class1 obj=new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string lid = "select count(Logid) from Login1 where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            string ccid = obj.Fn_Exescalar(lid);
            if (ccid == "1")
            {
                string iid = "select Logid from Login1 where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string logid = obj.Fn_Exescalar(iid);
                string sel = "select Usertype from Login1 where logid=" + logid + " ";
                string r = obj.Fn_Exescalar(sel);
                if (r == "User")
                {
                    Response.Redirect("log.aspx");
                }
                else if (r == "Admin")
                {
                    Response.Redirect("Category.aspx");
                }

            }

        }
    }
}