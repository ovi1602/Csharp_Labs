using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_ex4
{
    public partial class Form1 : Form
    {
        int val1; int val2;
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("audi");
            listBox1.Items.Add("bmw");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.GetItemText(listBox1.SelectedItem).Equals("audi"))
            {
                pictureBox1.ImageLocation = "audi.jpg";
            }
            if (listBox1.GetItemText(listBox1.SelectedItem).Equals("bmw")) pictureBox1.ImageLocation = "bmw.jpeg";

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                val1 = 1;
            }
            else
            {
                val1 = 0;
            }
            textBox1.Text = val1 + " " + val2;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                val1 = 1;
            }
            else
            {
                val1 = 0;
            }
            textBox1.Text = val1 + " " + val2;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                val2 = 1;
            }
            else
            {
                val2 = 0;
            }
            textBox1.Text = val1 + " " + val2;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                val2 = 1;
            }
            else
            {
                val2 = 0;
            }
            textBox1.Text = val1 + " " + val2;
        }
    }
}
