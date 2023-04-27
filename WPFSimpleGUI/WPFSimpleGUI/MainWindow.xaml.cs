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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSimpleGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnScrollUp_Click(object sender, RoutedEventArgs e)
        {
            // Kunne lave et array med de forskellige text boxes
            string temp;

            temp = tbLine1.Text;
            tbLine1.Text = tbLine2.Text;
            tbLine2.Text = tbLine3.Text;
            tbLine3.Text = tbLine4.Text;
            tbLine4.Text = temp;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbLine1.Text = "";
            tbLine2.Text = "";
            tbLine3.Text = "";
            tbLine4.Text = "";
        }

        private void btnScrollDown_Click(object sender, RoutedEventArgs e)
        {
            string temp;

            temp = tbLine4.Text;
            tbLine4.Text = tbLine3.Text;
            tbLine3.Text = tbLine2.Text;
            tbLine2.Text = tbLine1.Text;
            tbLine1.Text = temp;
        }
    }
}
