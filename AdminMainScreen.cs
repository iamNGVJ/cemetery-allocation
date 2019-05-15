using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadoma_City_Council_V2
{
    public partial class AdminMainScreen : Form
    {
        public AdminMainScreen()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            adminMainUserControl1.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            adminMainUserControl1.BringToFront();
        }

        private void FormClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            searchusercontrol1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            orderGrave1.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            mapUserControl1.BringToFront();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to logout?", "Logout Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
        }
    }
}
