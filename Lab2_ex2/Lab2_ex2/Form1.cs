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

namespace Lab2_ex2
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();

        public void InitializeFile()
        {
            StreamWriter s = new StreamWriter("file.txt");
            //s.WriteLine("user");
            //s.WriteLine("pass");
            s.Write("text1 text2");
            s.Close();
        }

        public void ReadFileData()
        {
            StreamReader r = new StreamReader(path: "file.txt");
            string line = string.Empty;
            while ((line = r.ReadLine()) != null)
            {
                string[] tempArray = line.Split(' ');
                this.list.Add(tempArray[0]);
                this.list.Add(tempArray[1]);
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeFile();
            ReadFileData();
            foreach (string element in list){
                listBox1.Items.Add(element);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.GetItemText(listBox1.SelectedItem));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.GetItemText(listBox2.SelectedItem));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
