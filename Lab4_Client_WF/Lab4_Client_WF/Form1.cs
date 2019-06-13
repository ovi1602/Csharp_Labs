using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Client_WF
{
    public partial class Form1 : Form
    {

        Lab4_Client_WF.ServiceReference1.MyfirstwebserviceSoapClient service = new Lab4_Client_WF.ServiceReference1.MyfirstwebserviceSoapClient();

        public Form1()
        {


            InitializeComponent();

            label5.Text = service.ShowDateAndTime();

            listBox1.Items.AddRange(service.ShowList().ToArray());

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(textBox1.Text);
            textBox3.Text = service.FtoC(val).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(textBox2.Text);
            textBox3.Text = service.CtoF(val).ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(textBox4.Text);
            textBox5.Text = service.ConvertToEuro(val).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = service.ShowDateAndTime();
        }
    }
}
