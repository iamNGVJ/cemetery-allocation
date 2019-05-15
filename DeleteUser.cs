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
    public partial class DeleteUser : UserControl
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(source);

            SqlDataReader rdr = null;

            try
            {
                con.Open();
                var select = "SELECT Id, username, password, actype FROM users Where username = '" + textBox2.Text + "'";
                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(source))
            {
                con.Open();

                string query = "DELETE FROM users WHERE Id = '" + Convert.ToInt32(textBox1.Text) + "'";

                using (SqlCommand updateCommand = con.CreateCommand())
                {
                    try
                    {
                        updateCommand.CommandType = CommandType.Text;
                        updateCommand.CommandText = query;

                        updateCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(textBox1.Text));

                        updateCommand.ExecuteNonQuery();
                        MessageBox.Show("Data record deleted!", "DB Connection With App.Config", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
