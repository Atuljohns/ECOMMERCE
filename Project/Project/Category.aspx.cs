﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class Category : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string stat = "Available";
            string cins = "insert into Category values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + stat + "')";
            int ins = obj.Fn_Exenonquery(cins);
            if (ins != 0)
            {
                Label1.Text = "Added";
            }
            string sel = "select count(cid) from Category where cname='" + TextBox1.Text + "'";
            string cid = obj.Fn_Exescalar(sel);
            if (cid == "1")
            {
                string sel1 = "select cid from Category where cname='" + TextBox1.Text + "'";
                string id = obj.Fn_Exescalar(sel1);
                Session["uid"] = id;

            }
        
        }   
    }
}