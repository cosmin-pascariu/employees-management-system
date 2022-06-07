using System;
using System.Data;
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
    public partial class departmentsForm : UserControl
    {
        private const bool SUCCES = true;
        private const int FIRST_COLUMN = 0;

        IStocareDepartments stocareDepartments = (IStocareDepartments)new StocareFactory().GetTipStocare(typeof(Department));
        IStocareEmployees stocareEmployees = (IStocareEmployees)new StocareFactory().GetTipStocare(typeof(Employees));

        public departmentsForm()
        {
            InitializeComponent();
            CheckStorage();
            ShowDepartmentsNumber();
            InitializeEmployeeComboBox();
            btnUpdateDepartment.Enabled = false;
            btnDeleteDepartment.Enabled = false;
        }

        void ShowDepartmentsNumber()
        {
            lblNumberOfDepartments.Text = "Number of departments: " + stocareDepartments.GetDepartmentsNumber();
        }

        public void CheckStorage()
        {
            if (stocareDepartments == null)
            {
                MessageBox.Show("Error on initialization!");
            }
        }

        private void btnAddDepartment_Click_1(object sender, EventArgs e)
        {
            if (dataValidation())
            {
                try
                {
                    var department = new Department(
                        txtDepartmentTitle.Text,
                       ((ComboItem)cmbEmployee.SelectedItem).Value
                     );

                    var rezultat = stocareDepartments.AddDepartment(department);
                    if (rezultat == SUCCES)
                    {
                        ShowDepartmentsNumber();
                        txtDepartmentTitle.Text = null;
                        lblMessageDepartment.ForeColor = Color.Green;
                        lblMessageDepartment.Text = "Role added!";
                    }
                    else
                    {
                        lblMessageDepartment.ForeColor = Color.Red;
                        lblMessageDepartment.Text = "Error at adding role";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excception" + ex.Message);
                }
            }
            
        }

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
                        cmbEmployee.Items.Add(new ComboItem(employee.first_name + " " + employee.last_name, (Int32)employee.employee_id));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnShowDepartments_Click(object sender, EventArgs e)
        {
            
            try
            {
                btnUpdateDepartment.Enabled = false;
                btnDeleteDepartment.Enabled = false;
                txtDepartmentTitle.Text = null;
                cmbEmployee.SelectedIndex = -1;
                lblMessageDepartment.Text = null;
                var departments = stocareDepartments.GetDepartments();

                dgvDepartments.DataSource = departments.Select(dep => new { dep.department_id,dep.title,dep.manager_id }).ToList();

                if (departments != null && departments.Any())
                {
                    dgvDepartments.DataSource = departments.Select(department => new { department.department_id, department.title,managerName = department.Manager.first_name+" "+department.Manager.last_name }).ToList();
                    dgvDepartments.Columns["department_id"].Visible = false;
                    dgvDepartments.Columns["title"].HeaderText = "Title";
                    dgvDepartments.Columns["managerName"].HeaderText = "Manager name";                   
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvDepartments.CurrentCell.RowIndex;
            string departmentID = dgvDepartments[FIRST_COLUMN, currentRowIndex].Value.ToString();
            try
            {
                
                stocareDepartments.DeleteDepartment(int.Parse(departmentID));
                btnShowDepartments_Click(sender, e);
                ShowDepartmentsNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvDepartments.CurrentCell.RowIndex;
            string departmentID = dgvDepartments[FIRST_COLUMN, currentRowIndex].Value.ToString();

            try
            {
                Department department = stocareDepartments.GetDepartment(Int32.Parse(departmentID));

                if (department != null)
                {
                    department.title = txtDepartmentTitle.Text;
                   department.manager_id = ((ComboItem)cmbEmployee.SelectedItem).Value;
                }

                var rezultat = stocareDepartments.UpdateDepartment(department);
                if (rezultat == SUCCES)
                {
                    txtDepartmentTitle.Text = null;
                    btnShowDepartments_Click(sender, e);
                    lblMessageDepartment.ForeColor = Color.Green;
                    lblMessageDepartment.Text = "Updated department!";
                }
                else
                {
                    lblMessageDepartment.ForeColor = Color.Red;
                    lblMessageDepartment.Text = "Department update error!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDepartments.CurrentCell.RowIndex > -1)
            {
                btnDeleteDepartment.Enabled = true;
                btnUpdateDepartment.Enabled = true;
            }
            int currentRowIndex = dgvDepartments.CurrentCell.RowIndex;
            string departmentID = dgvDepartments[FIRST_COLUMN, currentRowIndex].Value.ToString();

            try
            {
                Department department = stocareDepartments.GetDepartment(Int32.Parse(departmentID));
                var emp = stocareEmployees.GetEmployee(department.manager_id);

                //incarcarea datelor in controalele de pe forma
                if (department != null)
                {
                    txtDepartmentTitle.Text = department.title;
                    cmbEmployee.SelectedItem = new ComboItem(emp.first_name + " " + emp.last_name, emp.employee_id);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private bool dataValidation()
        {
            lblMessageDepartment.ForeColor = Color.Red;
            //validate department title
            if (txtDepartmentTitle.Text == string.Empty)
            {
                lblMessageDepartment.Text = "Department title must be entered!";
                return false;
            }
            else
            {
                if (!Regex.IsMatch(txtDepartmentTitle.Text, @"^[a-zA-Z ]+$"))
                {
                    lblMessageDepartment.Text = "Department title wrong format!";
                    return false;
                }
            }
            if(cmbEmployee.SelectedIndex == -1)
            {
                lblMessageDepartment.Text = "Select one manager!";
                return false;
            }
            lblMessageDepartment.ForeColor = Color.Green;
            return true;
        }
    }
}
