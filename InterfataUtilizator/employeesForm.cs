using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator
{
    public partial class employeesForm : UserControl
    {
        public employeesForm()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpEmployeeBirthDate.Format = DateTimePickerFormat.Custom;
            dtpEmployeeBirthDate.CustomFormat = "dd.MM.yyyy";
            
            dtpEmployeeHireDate.Format = DateTimePickerFormat.Custom;
            dtpEmployeeHireDate.CustomFormat = "dd.MM.yyyy";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmployeeFirstName.Text = null;
            txtEmployeeLastName.Text = null;
            txtEmployeeCNP.Text = null;
            txtEmployeeEmail.Text = null;
            txtEmployeePhoneNumber.Text = null;
            dtpEmployeeBirthDate.Value = DateTime.Today.AddYears(-16);
            dtpEmployeeHireDate.Value = DateTime.Today.AddDays(-1);
            txtEmployeeSalary.Text = null;
            cbxEmployeeRole.SelectedIndex = -1;
            cbxEmployeeDepartment.SelectedIndex = -1;
        }
    }
}
