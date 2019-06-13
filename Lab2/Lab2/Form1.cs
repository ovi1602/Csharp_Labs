using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string user = "user"; string password = "pass";
        string checkUser; string checkPass;
        public void InitializeLogin()
        {
            StreamWriter s = new StreamWriter("login.txt");
            //s.WriteLine("user");
            //s.WriteLine("pass");
            s.Write("user2 pass");
            s.Close();
        }

        public void ReadLoginData()
        {
            StreamReader r = new StreamReader(path: "login.txt");
            string line = string.Empty;
            while( (line = r.ReadLine()) != null)
            {
                string[] tempArray = line.Split(' ');
                this.checkUser = tempArray[0];
                this.checkPass = tempArray[1];
                Console.Write(checkUser + " " + checkPass);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           InitializeLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadLoginData();
            if (this.user.Equals(this.checkUser) && this.password.Equals(this.checkPass))
            {
                Form2 secondForm = new Form2();
                secondForm.Show();
            }
        }
    }
}
