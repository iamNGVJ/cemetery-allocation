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
    public partial class Searchusercontrol : UserControl
    {
        public Searchusercontrol()
        {
            InitializeComponent();
        }
        
        //search by name
        private void SearchButton_Click(object sender, EventArgs e)
        {
            String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(source);

            SqlDataReader rdr = null;

            try
            {
                con.Open();
                var select = "SELECT GraveID, Name, Surname, nID, GraveStatus, DOB FROM Members WHERE Name = '" + textBox1.Text + "'";
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

        //search by surname
        private void BySurname_Click(object sender, EventArgs e)
        {
            String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(source);

            SqlDataReader rdr = null;

            try
            {
                con.Open();
                var select = "SELECT GraveID, Name, Surname, nID, GraveStatus, DOB FROM Members WHERE Surname = '" + textBox2.Text + "'";
                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView2.ReadOnly = true;
                dataGridView2.DataSource = ds.Tables[0];
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

        //search by grave id
        private void ByGraveID_Click(object sender, EventArgs e)
        {
            String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(source);

            SqlDataReader rdr = null;

            try
            {
                con.Open();
                var select = "SELECT GraveID, Name, Surname, nID, GraveStatus, DOB FROM Members WHERE GraveID = '" + textBox3.Text + "'";
                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView3.ReadOnly = true;
                dataGridView3.DataSource = ds.Tables[0];
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

        //search by status
        private void ByStatus_Click(object sender, EventArgs e)
        {
            String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Carlos\Documents\logindat.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(source);

            SqlDataReader rdr = null;

            try
            {
                con.Open();
                if(Convert.ToString(comboBox1.SelectedItem) == "Available")
                {
                    var select = "SELECT GraveID, Name, Surname, nID, GraveStatus, DOB FROM Members WHERE GraveStatus = '0'";
                    var dataAdapter = new SqlDataAdapter(select, con);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView4.ReadOnly = true;
                    dataGridView4.DataSource = ds.Tables[0];
                }
                else
                {
                    var select = "SELECT GraveID, Name, Surname, nID, GraveStatus, DOB FROM Members WHERE GraveStatus = '" + comboBox1.SelectedItem + "'";
                    var dataAdapter = new SqlDataAdapter(select, con);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView4.ReadOnly = true;
                    dataGridView4.DataSource = ds.Tables[0];
                }
                
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
    }
}
