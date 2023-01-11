using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Admin : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int lgid = 0;
            string s = "select max(logid) from logid";
            string v = obj.Fn_Exescalar(s);
            if(v==null|v=="")
            {
                lgid = 1;
            }
            else
            {
                int id = Convert.ToInt32(v);
                lgid = id + 1;
            }
            string sel = "insert into admin values(" + lgid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + ",)";
            int i = obj.Fn_Exenonquery(sel);
            string u = "admin";
            string log = "insert into logid values(" + lgid + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','" + u + ",)";
            int j = obj.Fn_Exenonquery(log);

            Label1.Text = "inserted...";
        }
    }
}