using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculatorApp_10_1_15.BLL;

namespace CalculatorApp_10_1_15
{
    public partial class CalculatorUI : System.Web.UI.Page
    {
        DepartmentManager deptManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                departmentDropDownList.DataSource = deptManager.GetAllDepartments();
                departmentDropDownList.DataTextField = "Name";
                departmentDropDownList.DataValueField = "Id";
                departmentDropDownList.DataBind();
            }

        }
        
        protected void addButton_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = txtFirstName.Text;
            person.Address = txtAddress.Text;
            ViewState["Employee"] = person;
        }

        protected void retrieveButton_Click(object sender, EventArgs e)
        {
            Person person = (Person) ViewState["Employee"];
            txtFirstName.Text = person.FirstName;
            txtAddress.Text = person.Address;
        }
    }
}