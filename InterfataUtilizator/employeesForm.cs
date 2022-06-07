using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;
using System.Text.RegularExpressions;

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
            ShowNumberOfEmployees();
            btnUpdateEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = false;
        } 

        void ShowNumberOfEmployees()
        {
            lblNumberOfEmployee.Text = "Number of employees: " + stocareEmployees.GetEmployeesNumber();
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
            if (dataValidation())
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
                     );

                    var rezultat = stocareEmployees.AddEmployee(employee);
                    if (rezultat == SUCCES)
                    {
                        resetControls();
                        ShowNumberOfEmployees();
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
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                btnUpdateEmployee.Enabled = false;
                btnDeleteEmployee.Enabled = false;
                lblMessage.Text = null;
                resetControls();
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
                ShowNumberOfEmployees();
                btnShowEmployees_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > -1)
            {
                btnUpdateEmployee.Enabled = true;
                btnDeleteEmployee.Enabled = true;
            }
           
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

            if (dataValidation())
            {
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
                        btnShowEmployees_Click(sender, e);
                        lblMessage.ForeColor = Color.Green;
                        lblMessage.Text = "Updated employee!";
                        btnUpdateEmployee.Enabled = false;
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
            lblMessage.Text = null;
        }
        private bool dataValidation()
        {
            lblMessage.ForeColor = Color.Red;
            //validate first name
            if (txtEmployeeFirstName.Text == string.Empty)
            {
                lblMessage.Text = "First name must be entered!";
                return false;
            }
            else
            {
                if(!Regex.IsMatch(txtEmployeeFirstName.Text, @"^[a-zA-Z]+$"))
                {
                    lblMessage.Text = "Fisrt name must contain only letters!";
                    return false;
                }
            }
            //validate last name
            if (txtEmployeeLastName.Text == string.Empty)
            {
                lblMessage.Text = "Last name must be entered!";
                return false;
            }
            else
            {
                if (!Regex.IsMatch(txtEmployeeLastName.Text, @"^[a-zA-ZăĂîÎșȘțȚșȘâÂ]+$"))
                {      
                    lblMessage.Text = "Last name must contain only letters!";
                    return false;
                }
            }
            //validate CNP
            if (txtEmployeeCNP.Text == string.Empty)
            {
                lblMessage.Text = "CNP must be entered!";
                return false;
            }
            else
            {
                if(txtEmployeeCNP.Text.Length != 13)
                {
                    lblMessage.Text = "Incorrect length of CNP!";
                    return false;
                }
                if (!txtEmployeeCNP.Text.All(char.IsDigit))
                {
                    lblMessage.Text = "CNP must contain only numbers!";
                    return false;
                }
            }
            //validate email
            if (txtEmployeeEmail.Text == string.Empty)
            {
                lblMessage.Text = "Email must be entered!";
                return false;
            }
            else
            {
                if (!Regex.IsMatch(txtEmployeeEmail.Text, @"^[a-zA-Z@.]+$"))
                {
                    lblMessage.Text = "Email wrong format!";
                    return false;
                }
            }
            //validate phone number
            if (txtEmployeePhoneNumber.Text == string.Empty)
            {
                lblMessage.Text = "Phone number must be entered!";
                return false;
            }
            else
            {
                if(txtEmployeePhoneNumber.Text.Length != 10)
                {
                    lblMessage.Text = "Incorrect length of phone number!";
                    return false;
                }
                if (!txtEmployeePhoneNumber.Text.All(char.IsDigit))
                {
                    lblMessage.Text = "Phone number wrong format!";
                    return false;
                }
            }
            //validate salary
            if (txtEmployeeSalary.Text == string.Empty)
            {
                lblMessage.Text = "Salary must be entered!";
                return false;
            }
            else
            {
                if (!txtEmployeeSalary.Text.All(char.IsDigit))
                {
                    lblMessage.Text = "Salary wrong format!";
                    return false;
                }
            }
            lblMessage.ForeColor = Color.Green;
            return true;
        }
    }
}
