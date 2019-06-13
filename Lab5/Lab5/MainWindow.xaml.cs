using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeLogin();
        }


        private string checkUser, checkPass;
        public void InitializeLogin()
        {
            StreamWriter s = new StreamWriter("login.txt");
            //s.WriteLine("user");
            //s.WriteLine("pass");
            s.Write("user pass");
            s.Close();
        }

        public void ReadLoginData()
        {
            StreamReader r = new StreamReader(path: "login.txt");
            string line = string.Empty;
            while ((line = r.ReadLine()) != null)
            {
                string[] tempArray = line.Split(' ');
                this.checkUser = tempArray[0];
                this.checkPass = tempArray[1];
                Console.Write(checkUser + " " + checkPass);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReadLoginData();
            if (textbox1.Text.Equals(this.checkUser) && textbox2.Text.Equals(this.checkPass))
            {
                //MessageBox.Show("success");
                Window1 w = new Window1(textbox1.Text);
                w.Show();
            }
            else
            {
                MessageBox.Show("failed" + this.checkUser);
            }
        }
    }
}
