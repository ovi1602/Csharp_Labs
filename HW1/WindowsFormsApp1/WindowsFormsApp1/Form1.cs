using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            disableTextbox();
        }

        void disableTextbox()
        {
            textBox1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void clearAll(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.ro/search?q=" + textBox1.Text + "&hl=ro&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjJzYfIlrbhAhWMsKQKHb0QC7IQ_AUIDigB&biw=1920&bih=969");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) textBox1.Enabled = true;
            if (checkBox1.Checked == false)
            {
                disableTextbox();
                //MessageBox.Show("a");
            }
        }

 


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
