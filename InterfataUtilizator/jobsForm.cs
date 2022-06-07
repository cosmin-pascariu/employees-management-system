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
    public partial class jobsForm : UserControl
    {
        private const bool SUCCES = true;
        private const int FIRST_COLUMN = 0;

        IStocareRoles stocareRoles = (IStocareRoles)new StocareFactory().GetTipStocare(typeof(Role));

        public jobsForm()
        {
            InitializeComponent();
            CheckStorage();
            ShowRolesNumber();
            btnUpdateRole.Enabled = false;
            btnDeleteRole.Enabled = false;
        }

        void ShowRolesNumber()
        {
            lblNumberOfRoles.Text = "Number of roles: " + stocareRoles.GetRolesNumber();
            
        }
        public void CheckStorage()
        {
            if (stocareRoles == null)
            {
                MessageBox.Show("Error on initialization!");
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            if (dataValidation())
            {
                try
                {
                    var role = new Role(
                        txtRoleTitle.Text
                     );

                    var rezultat = stocareRoles.AddRole(role);
                    if (rezultat == SUCCES)
                    {
                        txtRoleTitle.Text = null;
                        ShowRolesNumber();
                        lblMessageRole.ForeColor = Color.Green;
                        lblMessageRole.Text = "Role added!";
                    }
                    else
                    {
                        lblMessageRole.ForeColor = Color.Red;
                        lblMessageRole.Text = "Error at adding role";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excception" + ex.Message);
                }
            }
        }

        private void btnShowRoles_Click(object sender, EventArgs e)
        {
            try
            {
                btnUpdateRole.Enabled = false;
                btnDeleteRole.Enabled = false;
                lblMessageRole.Text = null;
                txtRoleTitle.Text = null;
                var roles = stocareRoles.GetRoles();
                if (roles != null && roles.Any())
                {
                    dgvRoles.DataSource = roles.Select(role => new { role.role_id,role.title }).ToList();

                    dgvRoles.Columns["role_id"].Visible = false;
                    dgvRoles.Columns["title"].HeaderText = "Title";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvRoles.CurrentCell.RowIndex;
            string roleID = dgvRoles[FIRST_COLUMN, currentRowIndex].Value.ToString();
            try
            {
                stocareRoles.DeleteRole(int.Parse(roleID));
                txtRoleTitle.Text = null;
                ShowRolesNumber();
                btnShowRoles_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvRoles.CurrentCell.RowIndex;
            string roleID = dgvRoles[FIRST_COLUMN, currentRowIndex].Value.ToString();

            if (dataValidation())
            {
                try
                {
                    Role role = stocareRoles.GetRole(Int32.Parse(roleID));

                    if (role != null)
                    {
                        role.title = txtRoleTitle.Text;
                    }

                    var rezultat = stocareRoles.UpdateRole(role);
                    if (rezultat == SUCCES)
                    {
                        txtRoleTitle.Text = null;
                        btnShowRoles_Click(sender, e);
                        lblMessageRole.ForeColor = Color.Green;
                        lblMessageRole.Text = "Updated role!";
                    }
                    else
                    {
                        lblMessageRole.ForeColor = Color.Red;
                        lblMessageRole.Text = "Role update error!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dgvRoles.CurrentCell.RowIndex;
            string roleID = dgvRoles[FIRST_COLUMN, currentRowIndex].Value.ToString();

            if(dgvRoles.SelectedRows.Count > -1)
            {
                btnUpdateRole.Enabled = true;
                btnDeleteRole.Enabled = true;
            }

            try
            {
                Role role = stocareRoles.GetRole(Int32.Parse(roleID));

                //incarcarea datelor in controalele de pe forma
                if (role != null)
                {
                    txtRoleTitle.Text = role.title;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private bool dataValidation()
        {
            lblMessageRole.ForeColor = Color.Red;
            //validate role title
            if (txtRoleTitle.Text == string.Empty)
            {
                lblMessageRole.Text = "Role title must be entered!";
                return false;
            }
            else
            {
                if (!Regex.IsMatch(txtRoleTitle.Text, @"^[a-zA-Z ]+$"))
                {
                    lblMessageRole.Text = "Role title wrong format!";
                    return false;
                }
            }
            lblMessageRole.ForeColor = Color.Green;
            return true;
        } 

    }
}
