using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Lab5
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string user;
        public Window1(string user)
        {
            this.user = user;
            InitializeComponent();
            label.Content = "Hello, " + user;
        }

        private void Butonclose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Colorbutton_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb(byte.Parse(R.Text), byte.Parse(G.Text), byte.Parse(B.Text)));
            colorbutton.Background = brush;
        }
    }
}
