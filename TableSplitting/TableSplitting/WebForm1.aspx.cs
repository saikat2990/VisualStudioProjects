using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TableSplitting
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                GridView1.DataSource = GetEmployeeDetailsIncludeContactDetails();
            }
            else {
                GridView1.DataSource = GetEmployee();
            }
            GridView1.DataBind();
        }
        private DataTable GetEmployeeDetailsIncludeContactDetails() {

            DotnetLearning employeeDBContext = new DotnetLearning();
            List<EmployeeData> employees = employeeDBContext.EmployeeDatas.Include("EmployeeDetails").ToList();
            DataTable dt = new DataTable();
            DataColumn[] dataColumns = {
                new DataColumn("Name"),
                new DataColumn("Salary"),
                new DataColumn("Email"),
                new DataColumn("PhnNumber")
            };
            dt.Columns.AddRange(dataColumns);

            foreach (EmployeeData employee in employees) {
                DataRow dr = dt.NewRow();
                dr["Name"] = employee.Name;
                dr["Salary"] = employee.Salary;
                dr["Email"] = employee.EmployeeDetails.Email;
                dr["phnNumber"] = employee.EmployeeDetails.PhnNumber;
                dt.Rows.Add(dr);
            }
            return dt;

        }
        private DataTable GetEmployee()
        {

            DotnetLearning employeeDBContext = new DotnetLearning();
            List<EmployeeData> employees = employeeDBContext.EmployeeDatas.ToList();
            DataTable dt = new DataTable();
            DataColumn[] dataColumns = {
                new DataColumn("ID"),
                new DataColumn("Name"),
                new DataColumn("Salary")
            };
            dt.Columns.AddRange(dataColumns);

            foreach (EmployeeData employee in employees)
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = employee.EmployeeID;
                dr["Name"] = employee.Name;
                dr["Salary"] = employee.Salary;
                dt.Rows.Add(dr);
            }
            return dt;

        }

    }
}