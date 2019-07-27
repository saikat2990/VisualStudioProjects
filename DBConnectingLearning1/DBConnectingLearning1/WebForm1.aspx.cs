using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace DBConnectingLearning1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try{
                SqlConnection mySql = new SqlConnection(ConfigurationManager.ConnectionStrings["saikatConnectionString"].ConnectionString);
                mySql.Open();
                string insert = "insert into student(name,roll,Dpt) values(@name,@roll,@Dpt)";
                SqlCommand cmd = new SqlCommand(insert, mySql);

                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@roll", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Dpt", TextBox3.Text);
                cmd.ExecuteNonQuery();
                Response.Redirect("home.aspx");
                mySql.Close();
            }catch(Exception ex){

                Response.Write(ex);
            }
        }
    }
}