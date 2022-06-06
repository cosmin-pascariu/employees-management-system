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
    public partial class departmentsForm : UserControl
    {
        private const bool SUCCES = true;
        private const int FIRST_COLUMN = 0;

        IStocareDepartments stocareDepartments = (IStocareDepartments)new StocareFactory().GetTipStocare(typeof(Department));

        public departmentsForm()
        {
            InitializeComponent();
            CheckStorage();
            ShowDepartmentsNumber();
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
          
                try
                {
                    var department = new Department(
                        txtDepartmentTitle.Text,
                        Int32.Parse(txtManagerId.Text),
                        0
                     );

                    var rezultat = stocareDepartments.AddDepartment(department);
                    if (rezultat == SUCCES)
                    {
                    ShowDepartmentsNumber();
                        txtDepartmentTitle.Text = null;
                    txtManagerId.Text = null;
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

        private void btnShowDepartments_Click(object sender, EventArgs e)
        {

            try
            {
                lblMessageDepartment.Text = null;
                var departments = stocareDepartments.GetDepartments();
                if (departments != null && departments.Any())
                {
                    dgvDepartments.DataSource = departments.Select(department => new { department.department_id, department.title,department.manager_id }).ToList();

                    dgvDepartments.Columns["department_id"].Visible = false;
                    dgvDepartments.Columns["title"].HeaderText = "Title";
                    dgvDepartments.Columns["manager_id"].HeaderText = "Manager ID";
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

                //incarcarea datelor in controalele de pe forma
                if (department != null)
                {
                    department.title = txtDepartmentTitle.Text;
                   department.manager_id = Int32.Parse(txtManagerId.Text);
                }

                var rezultat = stocareDepartments.UpdateDepartment(department);
                if (rezultat == SUCCES)
                {
                    txtDepartmentTitle.Text = null;
                    txtManagerId.Text = null;
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

            int currentRowIndex = dgvDepartments.CurrentCell.RowIndex;
            string departmentID = dgvDepartments[FIRST_COLUMN, currentRowIndex].Value.ToString();

            try
            {
                Department department = stocareDepartments.GetDepartment(Int32.Parse(departmentID));

                //incarcarea datelor in controalele de pe forma
                if (department != null)
                {
                    txtDepartmentTitle.Text = department.title;
                    txtManagerId.Text = department.manager_id.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
