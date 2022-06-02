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
    public partial class employeesForm : UserControl
    {
        private const bool SUCCES = true;
        private const int FIRST_COLUMN = 0;

        IStocareEmployees stocareEmployees = (IStocareEmployees)new StocareFactory().GetTipStocare(typeof(Employees));

        public employeesForm()
        {
            InitializeComponent();
            SetMyCustomFormat();
            CheckStorage();
        } 

        public void CheckStorage()
        {
            if (stocareEmployees == null)
            {
                MessageBox.Show("Error on initialization!");
            }
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpEmployeeBirthDate.Format = DateTimePickerFormat.Custom;
            dtpEmployeeBirthDate.CustomFormat = "dd.MM.yyyy";
            dtpEmployeeBirthDate.MaxDate = DateTime.Today.AddYears(-16);
            
            dtpEmployeeHireDate.Format = DateTimePickerFormat.Custom;
            dtpEmployeeHireDate.CustomFormat = "dd.MM.yyyy";
            dtpEmployeeHireDate.MaxDate = DateTime.Today;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetControls();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = new Employees(
                    txtEmployeeFirstName.Text,
                    txtEmployeeLastName.Text,
                    txtEmployeeCNP.Text,
                    txtEmployeeEmail.Text,
                    txtEmployeePhoneNumber.Text,
                    Convert.ToDateTime(dtpEmployeeBirthDate.Text),
                    Convert.ToDateTime(dtpEmployeeHireDate.Text),
                    double.Parse(txtEmployeeSalary.Text),
                    0
                 ) ;
               
                var rezultat = stocareEmployees.AddEmployee(employee);
                if (rezultat == SUCCES)
                {
                    resetControls();
                    btnShowEmployees_Click(sender, e);
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
                var employees = stocareEmployees.GetEmployees();
                if (employees != null && employees.Any())
                {
                    dgvEmployees.DataSource = employees.Select(emp => new { emp.employee_id, emp.first_name,emp.last_name,emp.cnp,emp.email,emp.phone_number,emp.salary }).ToList();

                    dgvEmployees.Columns["employee_id"].Visible = false;
                    dgvEmployees.Columns["last_name"].HeaderText = "Last Name";
                    dgvEmployees.Columns["first_name"].HeaderText = "First Name";
                    dgvEmployees.Columns["cnp"].HeaderText = "CNP";
                    dgvEmployees.Columns["email"].HeaderText = "EMAIL";
                    dgvEmployees.Columns["phone_number"].HeaderText = "TEL";
                    dgvEmployees.Columns["salary"].HeaderText = "SALARY";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvEmployees.CurrentCell.RowIndex;
            string employeeID = dgvEmployees[FIRST_COLUMN, currentRowIndex].Value.ToString();
            try
            {
                stocareEmployees.DeleteEmployee(int.Parse(employeeID));
                btnShowEmployees_Click(sender, e);
            }
            catch(Exception ex)
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
                Employees emp = stocareEmployees.GetEmployee(Int32.Parse(employeeID));

                //incarcarea datelor in controalele de pe forma
                if (emp != null)
                {
                    txtEmployeeFirstName.Text = emp.first_name;
                    txtEmployeeLastName.Text = emp.last_name;
                    txtEmployeeCNP.Text = emp.cnp;
                    txtEmployeeEmail.Text = emp.email;
                    txtEmployeePhoneNumber.Text = emp.phone_number;
                    dtpEmployeeBirthDate.Text = emp.birth_date.ToString();
                    dtpEmployeeHireDate.Text = emp.hire_date.ToString();
                    txtEmployeeSalary.Text = emp.salary.ToString();
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
                Employees emp = stocareEmployees.GetEmployee(Int32.Parse(employeeID));
                if (emp != null)
                {
                    emp.first_name = txtEmployeeFirstName.Text;
                    emp.last_name = txtEmployeeLastName.Text;
                    emp.cnp = txtEmployeeCNP.Text;
                    emp.email = txtEmployeeEmail.Text;
                    emp.phone_number = txtEmployeePhoneNumber.Text;
                    emp.birth_date = Convert.ToDateTime(dtpEmployeeBirthDate.Text);
                    emp.hire_date = Convert.ToDateTime(dtpEmployeeBirthDate.Text);
                    emp.salary = double.Parse(txtEmployeeSalary.Text);
                }

                var rezultat = stocareEmployees.UpdateEmployee(emp);
                if (rezultat == SUCCES)
                {
                    resetControls();
                    btnShowEmployees_Click(sender,e);
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

        public void resetControls()
        {
            txtEmployeeFirstName.Text = null;
            txtEmployeeLastName.Text = null;
            txtEmployeeCNP.Text = null;
            txtEmployeeEmail.Text = null;
            txtEmployeePhoneNumber.Text = null;
            dtpEmployeeBirthDate.Value = DateTime.Today.AddYears(-16);
            dtpEmployeeHireDate.Value = DateTime.Today;
            txtEmployeeSalary.Text = null;
            cbxEmployeeRole.SelectedIndex = -1;
            cbxEmployeeDepartment.SelectedIndex = -1;
            lblMessage.Text = null;
        }
    }
}
