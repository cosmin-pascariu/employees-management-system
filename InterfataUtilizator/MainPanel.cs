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
    public partial class MainPanel : Form
    {
        static MainPanel _obj;

        public static MainPanel Instance
        {

            get
            {
                if (_obj == null)
                {
                    _obj = new MainPanel();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Button HomeButton
        {
            get { return btnHome; }
            set { btnHome = value; }
        }

        //window movement
        bool pressedButton;
        int movX;
        int movY;
        private const int GAP = 70;
        public MainPanel()
        {
            InitializeComponent();
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();

            _obj = this;
            homeForm homeContent = new homeForm();
            homeContent.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(homeContent);
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            pressedButton = true;
            movX = e.X + GAP;
            movY = e.Y;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressedButton)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            pressedButton = false;
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cosmin-pascariu/employees-management-system.git"); //link to github repository
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["homeForm"].BringToFront();
            btnHome.Enabled = false;
            btnEmployees.Enabled = true;
            btnJobs.Enabled = true;
            btnDepartments.Enabled = true;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Instance.PnlContainer.Controls.ContainsKey("employeesForm"))
            {
                employeesForm eF = new employeesForm();
                eF.Dock = DockStyle.Fill;
                MainPanel.Instance.PnlContainer.Controls.Add(eF);
            }
            PnlContainer.Controls["employeesForm"].BringToFront();
            btnHome.Enabled = true;
            btnEmployees.Enabled = false;
            btnJobs.Enabled = true;
            btnDepartments.Enabled = true;

        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Instance.PnlContainer.Controls.ContainsKey("jobsForm"))
            {
                jobsForm jF = new jobsForm();
                jF.Dock = DockStyle.Fill;
                MainPanel.Instance.PnlContainer.Controls.Add(jF);
            }
            PnlContainer.Controls["jobsForm"].BringToFront();
            btnHome.Enabled = true;
            btnEmployees.Enabled = true;
            btnJobs.Enabled = false;
            btnDepartments.Enabled = true;
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Instance.PnlContainer.Controls.ContainsKey("departmentsForm"))
            {
                departmentsForm dF = new departmentsForm();
                dF.Dock = DockStyle.Fill;
                MainPanel.Instance.PnlContainer.Controls.Add(dF);
            }
            PnlContainer.Controls["departmentsForm"].BringToFront();
            btnHome.Enabled = true;
            btnEmployees.Enabled = true;
            btnJobs.Enabled = true;
            btnDepartments.Enabled = false; ;
        }
    }
}
