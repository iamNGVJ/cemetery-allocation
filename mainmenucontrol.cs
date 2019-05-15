using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadoma_City_Council_V2
{
    public partial class mainmenucontrol : UserControl
    {
        public mainmenucontrol()
        {
            InitializeComponent();
            allGraves1.Hide();
            helpUserControl1.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            allGraves1.Show();
            allGraves1.BringToFront();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            helpUserControl1.Show();
            helpUserControl1.BringToFront();
        }
    }
}
