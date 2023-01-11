using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Project
{
    public partial class User : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int lgid = 0;
            string sel = "select max(logid) from Login1";
            string v = obj.Fn_Exescalar(sel);
            if(v==null|v=="")
            {
                lgid = 1;
            }
            else
            {
                int id = Convert.ToInt32(v);
                lgid = id + 1;
            }
            string status = "available";
            string s = "insert into User1 values(" + lgid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','"+status+"')";
            int i = obj.Fn_Exenonquery(s);
            string u = "User";
            string log = "insert into Login1 values(" + lgid + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','" + u + "')";
            int j = obj.Fn_Exenonquery(log);

            Label1.Text = "Inserted";

        }
    }
}