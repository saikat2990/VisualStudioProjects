using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vidly
{
    public partial class SessionState2 : System.Web.UI.Page
    {
        int countClick = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Number of  Application: " + Application["TotalApplications"]);
            Response.Write("<br/>");
            Response.Write("Number of  Users Online: " + Application["TotalUserSessions"]);

            if (!IsPostBack)
            {
                if (Session["Clicks"] == null)
                {
                    Session["Clicks"] = 0;
                }
                TextBox2.Text = Session["Clicks"].ToString();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // countClick = Convert.ToInt32(TextBox1.Text) + 1;
            // TextBox1.Text = countClick.ToString();

            int ClicksCount = (int)Session["Clicks"] + 1;
            TextBox2.Text = ClicksCount.ToString();
            Session["Clicks"] = ClicksCount;
        }
    }
}
