using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPloginPractice
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection SqlCon = new SqlConnection("Data Source=LAPTOP-OJ1LCGF3; Initial Catalog=ASPLogin; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("SELECT * FROM useraccount WHERE UserName='" + TxtUsername.Text + "' AND Password='" + TxtPassword.Text + "'", SqlCon);
            DataTable DT = new DataTable();
            SQLAdapter.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                messagelbl.Visible = true;
                messagelbl.Text = "Succesfully loggedin";
                messagelbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                messagelbl.Text = "Invalid UserName or Password";
                messagelbl.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}