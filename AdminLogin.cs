using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kadoma_City_Council_V2
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conx = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Carlos\Documents\logindat.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sda = new SqlDataAdapter("select  count(*) from users where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'and actype='ADMIN'", conx);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                AdminMainScreen mm = new AdminMainScreen();
                mm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Login Credentials", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are switching to a 'general' user account", "Alert", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                this.Hide();
                LoginForm lg = new LoginForm();
                lg.ShowDialog();
            }
        }

        private void FormClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
