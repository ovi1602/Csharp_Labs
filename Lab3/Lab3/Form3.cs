using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form3 : Form
    {
        SqlConnection myCon = new SqlConnection();
        public Form3()
        {
            InitializeComponent();
            datGridViewLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void datGridViewLoad()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            string sql = "SELECT * FROM Facultati";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataTable dtbl = new DataTable();
            connection.Open();
            dataadapter.Fill(dtbl);
            connection.Close();
            dataGridView1.DataSource = dtbl;
            //dataGridView1.DataMember = "Facultati";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            string sql = "SELECT * FROM Facultati";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataTable dtbl = new DataTable();
            connection.Open();
            dataadapter.Fill(dtbl);
            connection.Close();
            dataGridView1.DataSource = dtbl;
        }

        private void button2_Click(object sender, EventArgs e)
        {



                string commandText = "INSERT INTO Facultati (Id, Code, NameFac) VALUES (@val0, @val1, @val2)";
                try
                {
                    myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                    myCon.Open();
                    int lastId;
                    SqlCommand IdCommand = new SqlCommand("SELECT MAX(id) FROM Facultati", myCon);
                    lastId = (int)IdCommand.ExecuteScalar();
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = myCon;
                    comm.CommandText = commandText;
                    comm.Parameters.AddWithValue("@val0", lastId + 1);
                    comm.Parameters.AddWithValue("@val1", textBox1.Text);
                    comm.Parameters.AddWithValue("@val2", textBox2.Text);
                  

                    comm.ExecuteNonQuery();
                    myCon.Close();
                    MessageBox.Show("Success");
                }
                catch (SqlException xe)
                {
                    myCon.Close();
                    MessageBox.Show("error" + xe);
                }
            }

        private void button3_Click(object sender, EventArgs e) {
            
                if (dataGridView1.SelectedRows.Count == 0) { 
                    MessageBox.Show("Select the entire row (left arrow)");
                return;
            }
            string sql = "DELETE FROM Facultati WHERE ID = @rowID";
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            myCon.Open();
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);
            SqlCommand deleteRecord = new SqlCommand(sql, myCon);
            deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
            deleteRecord.ExecuteNonQuery();
            dataGridView1.Rows.RemoveAt(selectedIndex);
            myCon.Close();
        }
    }
}
