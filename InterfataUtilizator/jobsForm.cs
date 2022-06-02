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
    public partial class jobsForm : UserControl
    {
        private const bool SUCCES = true;
        private const int FIRST_COLUMN = 0;

        IStocareRoles stocareRoles = (IStocareRoles)new StocareFactory().GetTipStocare(typeof(Role));

        public jobsForm()
        {
            InitializeComponent();
            CheckStorage();
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
            try
            {
                var role = new Role(
                    txtRoleTitle.Text,
                    0
                 );

                var rezultat = stocareRoles.AddRole(role);
                if (rezultat == SUCCES)
                {
                    txtRoleTitle.Text = null;
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "Role added!";
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Error at adding role";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excception" + ex.Message);
            }
        }

        private void btnShowRoles_Click(object sender, EventArgs e)
        {
            try
            {
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

            try
            {
                Role role = stocareRoles.GetRole(Int32.Parse(roleID));
               

                //incarcarea datelor in controalele de pe forma
                if (role != null)
                {
                    role.title = txtRoleTitle.Text;
                }

                var rezultat = stocareRoles.UpdateRole(role);
                if (rezultat == SUCCES)
                {
                    txtRoleTitle.Text = null;
                    btnShowRoles_Click(sender, e);
                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "Updated role!";
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Role update error!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dgvRoles.CurrentCell.RowIndex;
            string roleID = dgvRoles[FIRST_COLUMN, currentRowIndex].Value.ToString();

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

    }
}
