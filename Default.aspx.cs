using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGet_Click(object sender, EventArgs e)
    {
        EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
        EmployeeService.Employee employee= client.GetEmployee(Convert.ToInt32(txtId.Text));
        txtName.Text = employee.Name;
        txtGender.Text = employee.Gender;
        txtDOB.Text = employee.DOB.ToShortDateString();
        lblMessage.Text = "Employee Retrieved";

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
        EmployeeService.Employee employee = new EmployeeService.Employee();
        employee.Id = Convert.ToInt32(txtId.Text);
        employee.Name = txtName.Text;
        employee.Gender = txtGender.Text;
        employee.DOB = Convert.ToDateTime(txtDOB.Text);
        client.SaveEmployee(employee);
        lblMessage.Text = "Employee Saved";
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
        EmployeeService.Employee employee = new EmployeeService.Employee();
        employee.Id = Convert.ToInt32(txtId.Text);
        employee.Name = txtName.Text;
        employee.Gender = txtGender.Text;
        employee.DOB = Convert.ToDateTime(txtDOB.Text);
        client.UpdateEmployee(employee);
        lblMessage.Text = "Employee Details Updated";
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
        client.DeleteEmployee(Convert.ToInt32(txtId.Text));
        lblMessage.Text = "Employee Deleted";
    }
}