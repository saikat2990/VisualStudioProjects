using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Vidly
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* if (IsPostBack) {
                 Response.Write("I am in post back to web server"+"<br/>");
             }
             if (!IsPostBack) {
                 Response.Write("This is in get message to client"+ "<br/>");
             }*/
            if (!IsPostBack)
                LoadCityDropdownList();

            Load.Click += new EventHandler(Button1_Click1);

            Load.Command += new CommandEventHandler(Button1_Command);

            TopEmployee.Command += new CommandEventHandler(TopEmployee_Command);

            BottomEmployee.Command += new CommandEventHandler(BottomEmployee_Command); 


        }
        public void LoadCityDropdownList() {

            ListItem list1 = new ListItem("Chicago");
            DropDownList1.Items.Add(list1);

            ListItem list2 = new ListItem("los angeles");
            DropDownList1.Items.Add(list2);

            ListItem list3 = new ListItem("Dhilli");
            DropDownList1.Items.Add(list3);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button clicked  <br/>");

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write(" Text is changed " + TextBox1.Text);

        
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            StringBuilder sbUserChoices = new StringBuilder();
            if (GraduateCheckBox.Checked) {
                sbUserChoices.Append(GraduateCheckBox.Text+", ");    
            }
            if (UnderGraduateCheckBox.Checked) {

                sbUserChoices.Append(UnderGraduateCheckBox.Text + ", ");
            }
            if (DoctrateCheckBox.Checked) {
                sbUserChoices.Append(DoctrateCheckBox.Text);
            }

            Response.Write("Your selection is " + sbUserChoices+"<br/>");
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Response.Write("Button command <br/>");
        }

        protected void TopEmployee_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandArgument.ToString()=="Top")Response.Write("You are in TopEmployee portion <br/> ");
        }

        protected void BottomEmployee_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandArgument.ToString() == "Bottom") Response.Write("You are in BottomEmployee portion <br/>");
        }
    }
}