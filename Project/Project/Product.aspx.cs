using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Project
{
    public partial class Product : System.Web.UI.Page
    {
        Class1 pro = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "select cid ,cname from category";
            DataSet ds = pro.Fn_Exedataset(str);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "cname";
            DropDownList1.DataValueField = "cid";
            DropDownList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pa = "/~PHS" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));
            string pstatus = "Available";
            string prins = "insert into product values (" + DropDownList1.SelectedItem.Value + ",'" + TextBox1.Text + "','" + pa + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int j = pro.Fn_Exenonquery(prins);
            if(j!=0)
            {
                Label1.Text = "Added";
            }
        }
    }
}