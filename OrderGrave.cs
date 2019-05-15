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
    public partial class OrderGrave : UserControl
    {
        public OrderGrave()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            /*
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string id = textBox3.Text;
            string gravestatus = Convert.ToString(comboBox1.SelectedItem);
            string address = textBox4.Text;
            int phonenumber = Convert.ToInt32(textBox5.Text);
            */

            if (textBox1.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER NAME");
            }
            else if (textBox2.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER SURNAME");
            }
            else if (textBox3.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER I.D");
            }
            else if (textBox4.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER ADDRESS");
            }
            else if (textBox5.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER PHONE");
            }
            else if (comboBox1.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER GRAVE STATUS");
            }
            else
            {
                String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();

                    string query = "update Members SET Name = '" + textBox1.Text + "', Surname = '" + textBox2.Text + "', Address = '" + textBox4.Text + "',PhoneNumber= '" + Convert.ToInt32(textBox5.Text) + "',GraveStatus ='" + comboBox1.SelectedItem + "',DOB ='" + dateTimePicker1.Value + "', nID ='" + textBox6.Text + "' where GraveID ='" + Convert.ToInt32(textBox3.Text) + "'";

                    using(SqlCommand updateCommand = con.CreateCommand())
                    {
                        updateCommand.CommandType = CommandType.Text;
                        updateCommand.CommandText = query;

                        updateCommand.Parameters.AddWithValue("@Name", textBox1.Text);
                        updateCommand.Parameters.AddWithValue("@Surname", textBox2.Text);
                        updateCommand.Parameters.AddWithValue("@Address", textBox4.Text);
                        updateCommand.Parameters.AddWithValue("@PhoneNumber", textBox5.Text);
                        updateCommand.Parameters.AddWithValue("@GraveStatus", comboBox1.SelectedItem);
                        updateCommand.Parameters.AddWithValue("@nID", textBox6.Text);
                        updateCommand.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

                        int row = updateCommand.ExecuteNonQuery();

                        if (row == 1)
                        {
                            MessageBox.Show("done!");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string gravestatus = Convert.ToString(comboBox1.SelectedItem);
            string address = textBox4.Text;
            int phonenumber = Convert.ToInt32(textBox5.Text);
            string nID = textBox6.Text;

            if (name.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER NAME");
            }
            else if (surname.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER SURNAME");
            }
            else if (address.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER ADDRESS");
            }
            else if (phonenumber.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER PHONE");
            }
            else if (gravestatus.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER GRAVE STATUS");
            }
            else
            {
                String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection con = new SqlConnection(source))
                {
                    con.Open();

                    string query = "insert into Members(Name,Surname,Address,PhoneNumber,GraveStatus, nID, DOB)values(@Name,@Surname,@Address,@PhoneNumber,@GraveStatus,@nID, @Date)";

                    using (SqlCommand updateCommand = con.CreateCommand())
                    {
                        updateCommand.CommandType = CommandType.Text;
                        updateCommand.CommandText = query;

                        updateCommand.Parameters.AddWithValue("@Name", name);
                        updateCommand.Parameters.AddWithValue("@Surname", surname);
                        updateCommand.Parameters.AddWithValue("@Address", address);
                        updateCommand.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                        updateCommand.Parameters.AddWithValue("@GraveStatus", gravestatus);
                        updateCommand.Parameters.AddWithValue("@nID", nID);
                        updateCommand.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

                        int row = updateCommand.ExecuteNonQuery();

                        if (row == 1)
                        {
                            MessageBox.Show("done!");
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
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

