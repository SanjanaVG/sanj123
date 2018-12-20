using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace emppro
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlCommand mycmd;
        string Temp;
        //static int clickStatus = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection("server=WSLKCMP5F-582; user id=sa; password=slk@SOFT; database=Adventure Works");
                Temp = "update Tbl_Employee set EmpName=@Empname,DOB=@dob,Gender=@gender,ContactNo=@Contactno,EmailId=@Emailid,DOJ=@doj,Department=@department,Designation=@designation,Salary=@salary,Password1=@password1,RoleId=@roleid where EmpId=@EmpId";
                mycmd = new SqlCommand(Temp, con);
                mycmd.Parameters.Add("@Empid", SqlDbType.NChar, 10);
                mycmd.Parameters.Add("@Empname", SqlDbType.NChar, 20);
                mycmd.Parameters.Add("@dob", SqlDbType.Date);
                mycmd.Parameters.Add("@gender", SqlDbType.NChar, 1);
                mycmd.Parameters.Add("@Contactno", SqlDbType.NChar, 10);
                mycmd.Parameters.Add("@Emailid", SqlDbType.NVarChar, 20);
                mycmd.Parameters.Add("@doj", SqlDbType.Date);
                mycmd.Parameters.Add("@department", SqlDbType.NChar, 30);
                mycmd.Parameters.Add("@designation", SqlDbType.NChar, 30);
                mycmd.Parameters.Add("@salary", SqlDbType.Int);
                mycmd.Parameters.Add("@password1", SqlDbType.NVarChar, 20);
                mycmd.Parameters.Add("@roleid", SqlDbType.Int);


                mycmd.Parameters[0].Value = TxtEmpId.Text;
                mycmd.Parameters[1].Value = TxtEmpName.Text;
                mycmd.Parameters[2].Value = TxtDob.Text;
                mycmd.Parameters[3].Value = RadioButtonList1.SelectedItem.Text;
                mycmd.Parameters[4].Value = TxtContact.Text;
                mycmd.Parameters[5].Value = TxtEmail.Text;
                mycmd.Parameters[6].Value = TxtDoj.Text;

                mycmd.Parameters[7].Value = TxtDept.Text;
                mycmd.Parameters[8].Value = TxtDesi.Text;
                mycmd.Parameters[9].Value = int.Parse(TxtSal.Text);

                mycmd.Parameters[10].Value = TxtPass.Text;
                mycmd.Parameters[11].Value = int.Parse(TxtRoleId.Text);
                try
                {
                    mycmd.Connection.Open();
                    if (mycmd.ExecuteNonQuery() == 0)
                        lblMsg.Text = "record not found";
                    else
                        lblMsg.Text = "record updated";
                    mycmd.Connection.Close();

                }
                catch (Exception ee)
                {
                    lblMsg.Text = "error in updating the record because" + ee.Message.ToString();
                    return;
                }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TxtEmpId.Text = "";
            TxtEmpName.Text = "";
            TxtDob.Text = "";
            TxtContact.Text = "";
            TxtEmail.Text = "";
            TxtDoj.Text = "";
            TxtDept.Text = "";
            TxtDesi.Text = "";
            TxtSal.Text = "";
            TxtPass.Text = "";
            TxtRoleId.Text = "";
        }
    }
}