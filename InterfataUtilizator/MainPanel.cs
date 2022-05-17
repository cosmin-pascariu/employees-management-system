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
    }
}
