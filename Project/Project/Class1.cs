using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    public class Class1
        {
            SqlConnection con;
            public Class1()
            {
                con = new SqlConnection(@"server=MI-ULTRA-BOOK\SQLEXPRESS;database=Project;Integrated security=true");
            }

            public int Fn_Exenonquery(string sqlquery)//insert,delete,update
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
            public string Fn_Exescalar(string sqlquery)//scalar functions
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                con.Open();
                string s = cmd.ExecuteScalar().ToString();
                con.Close();
                return s;
            }
            public SqlDataReader Fn_Exereader(string sqlquery)//read from databse
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            public DataSet Fn_Exedataset(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            public DataTable Fn_Exedatatable(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }