using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kadoma_City_Council_V2
{
    public partial class AdminMainUserControl : UserControl
    {
        public AdminMainUserControl()
        {
            InitializeComponent();
            addUser1.Hide();
            allGraves1.Hide();
            deleteUser1.Hide();
            allUsers1.Hide();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            addUser1.Show();
            addUser1.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            allGraves1.Show();
            allGraves1.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            deleteUser1.Show();
            deleteUser1.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            allUsers1.Show();
            allUsers1.BringToFront();
        }
    }
}
