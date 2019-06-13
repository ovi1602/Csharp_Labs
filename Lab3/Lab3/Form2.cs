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
    public partial class Form2 : Form
    {
        SqlConnection myCon = new SqlConnection();


        //Using Singleton Design Pattern in order to have a unique edit window
        private static Form2 f;
        private Form2()
        {
            InitializeComponent();
        }

        public static Form2 getInstance()
        {
            try
            {
                if (f == null)
                    f = new Form2();
                return f;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        //Setting the form to null every time the window is closed so that the app doesn't crash due to singleton

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Closed");
            Form2.f = null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {


            string commandText = "INSERT INTO Universitati (Id, NameUniv, City, Code) VALUES (@val0, @val1, @val2, @val3)";
            try
            {
                myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                myCon.Open();
                int lastId;
                SqlCommand IdCommand = new SqlCommand("SELECT MAX(id) FROM Universitati", myCon);
                lastId = (int)IdCommand.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", lastId + 1);
                comm.Parameters.AddWithValue("@val1", textBox_AddUniv.Text);
                comm.Parameters.AddWithValue("@val2", textBox_AddCity.Text);
                comm.Parameters.AddWithValue("@val3", textBox_AddCode.Text);
                //comm.CommandText = "INSERT INTO Universitati (NameUniv, City, Code) VALUES (" +
                //    textBox_AddUniv.ToString() + ", " + textBox_AddCity.ToString() + ", " + textBox_AddCode.ToString() + ")";
                
                comm.ExecuteNonQuery();
                myCon.Close();
                MessageBox.Show("Success");
            }
            catch(SqlException xe)
            {
                myCon.Close();
                MessageBox.Show("error" + xe);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string commandText = "DELETE FROM Universitati WHERE NameUniv = @val0";
            try
            {
                myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                myCon.Open();
  
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", SqlDbType.Text).Value = Convert.ToString(textBox_DeleteUni.Text);
                //comm.CommandText = "INSERT INTO Universitati (NameUniv, City, Code) VALUES (" +
                //    textBox_AddUniv.ToString() + ", " + textBox_AddCity.ToString() + ", " + textBox_AddCode.ToString() + ")";

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

        private void button2_Click(object sender, EventArgs e)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            try
            {
                string text = "UPDATE Universitati SET NameUniv = @val1, City = @val2, Code = @val3 WHERE NameUniv = @val0";
                myCon.Open();
                SqlCommand s = new SqlCommand();
                s.CommandText = text;
                s.Connection = myCon;
                s.Parameters.AddWithValue("@val0", textBox3.Text);
                s.Parameters.AddWithValue("@val1", newNameBox.Text);
                s.Parameters.AddWithValue("@val2", newCityBox.Text);
                s.Parameters.AddWithValue("@val3", newCodeBox.Text);
                s.ExecuteNonQuery();
                //SqlDataAdapter daUniv = new SqlDataAdapter(text , myCon);
                
 
                MessageBox.Show("Success");
                myCon.Close();
            }
            catch (SqlException xe)
            {
                myCon.Close();
                MessageBox.Show("error" + xe);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
