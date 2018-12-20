﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace emppro
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label3.Text = (string)Session["Name"]; 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string ConnectionString;
            
            SqlConnection MyCon;
            ConnectionString = "server=WSLKCMP5F-582;user id=sa;password=slk@SOFT;database=Adventure Works";
            MyCon = new SqlConnection(ConnectionString);
            MyCon.Open();
            try
            {
                String val = TextBox1.Text;
                if (TextBox1.Text != "")
                {
                    if (DropDownList1.SelectedValue == "EmpId")
                    {

                        string Query = "select EmpId,EmpName,DOB,Gender,ContactNo,EmailId,Department,Designation from Tbl_Employee where EmpId ='" + val + "'";

                        SqlDataAdapter sde = new SqlDataAdapter(Query, MyCon);
                        DataSet ds = new DataSet();
                        sde.Fill(ds);
                        if (ds.Tables[0].Rows.Count != 0)
                        {
                            DataGrid1.DataSource = ds;
                            DataGrid1.DataBind();
                            lblMsg.Text = "";
                        }
                        else
                        {
                            lblMsg.Text = "No record found";

                        }
                    }
                    else if (DropDownList1.SelectedValue == "EmpName")
                    {
                        string Query = "select EmpId,EmpName,DOB,Gender,ContactNo,EmailId,Department,Designation from Tbl_Employee where EmpName ='" + val + "'";
                        SqlDataAdapter sde = new SqlDataAdapter(Query, MyCon);
                        DataSet ds = new DataSet();
                        sde.Fill(ds);
                        if (ds.Tables[0].Rows.Count != 0)
                        {
                            DataGrid1.DataSource = ds;
                            DataGrid1.DataBind();
                            lblMsg.Text = "";
                        }
                        else
                        {
                            lblMsg.Text = "No record found";
                            
                        }
                    }
                }
                else
                { lblMsg.Text = "Enter a valid Employee Id or Employee name"; }
            }
            catch (Exception ee)
            {
                lblMsg.Text = "the error is" + ee.Message;
            }
            // finally { }
            MyCon.Close();

        }

    
    }
    }

