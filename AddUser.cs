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
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string username = textBox2.Text;
            string passkey = textBox3.Text;
            string actype = Convert.ToString(comboBox1.SelectedItem);

            if (id.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER ID");
            }
            else if (username.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER USERNAME");
            }
            else if (passkey.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER PASSKEY");
            }
            else if (actype.Equals(""))
            {
                MessageBox.Show("PLEASE CHOOSE ACCOUNT TYPE");
            }
            else
            {
                String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();
                     
                    string query = "update users SET username = '" + textBox2.Text + "',password = '" + textBox3.Text + "',actype = '" + comboBox1.SelectedItem + "' where Id ='" + Convert.ToInt32(textBox1.Text) + "'";

                    using (SqlCommand updateCommand = con.CreateCommand())
                    {
                        updateCommand.CommandType = CommandType.Text;
                        updateCommand.CommandText = query;

                        updateCommand.Parameters.AddWithValue("@username", textBox2.Text);
                        updateCommand.Parameters.AddWithValue("@password", textBox3.Text);
                        updateCommand.Parameters.AddWithValue("@actype", Convert.ToString(comboBox1.SelectedItem));

                        int row = updateCommand.ExecuteNonQuery();

                        if (row == 1)
                        {
                            MessageBox.Show("done!");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            comboBox1.SelectedItem = "";
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    con.Close();
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string passkey = textBox3.Text;
            string actype = Convert.ToString(comboBox1.SelectedItem);

            if (username.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER USERNAME");
            }
            else if (passkey.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER PASSKEY");
            }
            else if (actype.Equals(""))
            {
                MessageBox.Show("PLEASE CHOOSE ACCOUNT TYPE");
            }
            else
            {
                String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();

                    string query = "INSERT INTO users(username,password,actype) VALUES (@username,@password,@actype)";

                    using (SqlCommand updateCommand = con.CreateCommand())
                    {
                        updateCommand.CommandType = CommandType.Text;
                        updateCommand.CommandText = query;

                        updateCommand.Parameters.AddWithValue("@username", username);
                        updateCommand.Parameters.AddWithValue("@password", passkey);
                        updateCommand.Parameters.AddWithValue("@actype", actype);

                        int row = updateCommand.ExecuteNonQuery();

                        if (row == 1)
                        {
                            MessageBox.Show("done!");
                            textBox2.Clear();
                            textBox3.Clear();
                            comboBox1.SelectedItem = "";
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    con.Close();
                }
            }
        }
    }
}
