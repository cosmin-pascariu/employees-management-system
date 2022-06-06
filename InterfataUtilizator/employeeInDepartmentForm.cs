using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace InterfataUtilizator
{
    public partial class employeeInDepartmentForm : UserControl
    {
        private const bool SUCCES = true;
        private const int FIRST_COLUMN = 0;


        IStocareEmployees stocareEmployees = (IStocareEmployees)new StocareFactory().GetTipStocare(typeof(Employees));
        IStocareDepartments stocareDepartments = (IStocareDepartments)new StocareFactory().GetTipStocare(typeof(Department));
        IStocareRoles stocareRoles = (IStocareRoles)new StocareFactory().GetTipStocare(typeof(Role));
        IStocareEmployeeInDepartment stocareEmployeesInDepartments = (IStocareEmployeeInDepartment)new StocareFactory().GetTipStocare(typeof(EmployeeInDepartment));
        public employeeInDepartmentForm()
        {
            InitializeComponent();
            CheckStorage();
            SetMyCustomFormat();
            InitializeEmployeeComboBox();
            InitializeDepartmentComboBox();
            InitializeRoleComboBox();
        }

        public void CheckStorage()
        {
            if (stocareEmployees == null || stocareDepartments == null || stocareRoles == null)
            {
                MessageBox.Show("Error on initialization!");
            }
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpEmployeeStartDate.Format = DateTimePickerFormat.Custom;
            dtpEmployeeStartDate.CustomFormat = "dd.MM.yyyy";
            dtpEmployeeStartDate.MaxDate = DateTime.Today;

            dtpEmployeeStopDate.Format = DateTimePickerFormat.Custom;
            dtpEmployeeStopDate.CustomFormat = "dd.MM.yyyy";
            dtpEmployeeStopDate.MaxDate = DateTime.Today;
        }

        #region Initialize ComboBox
        public void InitializeEmployeeComboBox()
        {

            try
            {
                //delete previous items
                cmbEmployee.Items.Clear();

                var employees = stocareEmployees.GetEmployees();
                if (employees != null && employees.Any())
                {
                    foreach (var employee in employees)
                    {
                        cmbEmployee.Items.Add(new ComboItem(employee.first_name+" "+employee.last_name,(Int32)employee.employee_id));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        public void InitializeDepartmentComboBox()
        {

            try
            {
                //delete previous items
                cmbDepartment.Items.Clear();

                var departments = stocareDepartments.GetDepartments();
                if (departments != null && departments.Any())
                {
                    foreach (var department in departments)
                    {
                        cmbDepartment.Items.Add(new ComboItem(department.title, (Int32)department.department_id));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        public void InitializeRoleComboBox()
        {

            try
            {
                //delete previous items
                cmbRole.Items.Clear();

                var roles = stocareRoles.GetRoles();
                if (roles != null && roles.Any())
                {
                    foreach (var role in roles)
                    {
                        cmbRole.Items.Add(new ComboItem(role.title, (Int32)role.role_id));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        #endregion
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeInDepartment = new EmployeeInDepartment(
                    Convert.ToDateTime(dtpEmployeeStartDate.Text),
                    Convert.ToDateTime(dtpEmployeeStopDate.Text),
                    rdbY.Checked == true ? 'Y' : 'N',
                    ((ComboItem)cmbEmployee.SelectedItem).Value,
                    ((ComboItem)cmbDepartment.SelectedItem).Value,
                    ((ComboItem)cmbRole.SelectedItem).Value
                 );       

                var rezultat = stocareEmployeesInDepartments.AddEmployeeInDepartment(employeeInDepartment);
                if (rezultat == SUCCES)
                {
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "Employee added!";
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Error at adding employee";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excception" + ex.Message);
            }
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                var employees = stocareEmployeesInDepartments.GetEmployeesInDepartments();
                if (employees != null && employees.Any())
                {
                    dgvEmployees.DataSource = employees.Select(emp => new { emp.id, emp.employee_id, emp.department_id, emp.role_id, emp.start_date, emp.stop_date, emp.active}).ToList();

                    dgvEmployees.Columns["id"].Visible = false;
                    dgvEmployees.Columns["employee_id"].HeaderText = "Employee ID";
                    dgvEmployees.Columns["department_id"].HeaderText = "Department ID";
                    dgvEmployees.Columns["role_id"].HeaderText = "Role ID";
                    dgvEmployees.Columns["start_date"].HeaderText = "Start Date";
                    dgvEmployees.Columns["stop_date"].HeaderText = "Stop Date";
                    dgvEmployees.Columns["active"].HeaderText = "Active";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvEmployees.CurrentCell.RowIndex;
            string employeeID = dgvEmployees[FIRST_COLUMN, currentRowIndex].Value.ToString();

            try
            {
                EmployeeInDepartment emp = stocareEmployeesInDepartments.GetEmployeeInDepartment(Int32.Parse(employeeID));
                if (emp != null)
                {
                    emp.employee_id = ((ComboItem)cmbEmployee.SelectedItem).Value;
                    emp.department_id = ((ComboItem)cmbDepartment.SelectedItem).Value;
                    emp.role_id = ((ComboItem)cmbRole.SelectedItem).Value;
                    emp.start_date = Convert.ToDateTime(dtpEmployeeStartDate.Text);
                    emp.stop_date = Convert.ToDateTime(dtpEmployeeStopDate.Text);
                    emp.active = rdbY.Checked == true ? 'Y' : 'N';
                }

                var rezultat = stocareEmployeesInDepartments.UpdateEmployeeInDepartment(emp);
                if (rezultat == SUCCES)
                {
                    btnShowEmployees_Click(sender, e);
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "Updated employee!";
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Employee update error!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excception" + ex.Message);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvEmployees.CurrentCell.RowIndex;
            string employeeID = dgvEmployees[FIRST_COLUMN, currentRowIndex].Value.ToString();
            try
            {
                stocareEmployeesInDepartments.DeleteEmployeeInDepartment(int.Parse(employeeID));
                btnShowEmployees_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dgvEmployees.CurrentCell.RowIndex;
            string employeeID = dgvEmployees[FIRST_COLUMN, currentRowIndex].Value.ToString();

            try
            {
                EmployeeInDepartment emp = stocareEmployeesInDepartments.GetEmployeeInDepartment(Int32.Parse(employeeID));
               

                //incarcarea datelor in controalele de pe forma
                if (emp != null)
                {
                    cmbEmployee.SelectedItem = new ComboItem(emp.Employee.first_name+" "+emp.Employee.last_name,emp.employee_id);
                    cmbDepartment.SelectedItem = new ComboItem(emp.Department.title, emp.department_id);
                    cmbRole.SelectedItem = new ComboItem(emp.Role.title, emp.role_id);
                    dtpEmployeeStartDate.Text = emp.start_date.ToString();
                   dtpEmployeeStopDate.Text = emp.stop_date.ToString();
                    if (emp.active == 'Y')
                        rdbY.Checked = true;
                    else
                        rdbN.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
