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

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Jeg har disabled textboxes, hvis der ikke er en person endnu, fordi det crasher programmet
        // hvis man prøver at ændre på textboxes uden der er lavet en person endnu.
        private Controller controller;

        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
        }

        private void updateContent()
        {
            lbPersonCount.Content = $"Person Count {controller.PersonCount}";
            lbIndex.Content = $"Index {controller.PersonIndex}";
            if (controller.PersonCount != 0)
            {
                tbFirstName.Text = controller.CurrentPerson.FirstName;
                tbLastName.Text = controller.CurrentPerson.LastName;
                tbAge.Text = controller.CurrentPerson.Age.ToString();
                tbTelephone.Text = controller.CurrentPerson.TelephoneNo;
            }
            else
            {
                tbFirstName.Text = "";
                tbLastName.Text = "";
                tbAge.Text = 0;
                tbTelephone.Text = "";
            }
        }

        private void btnNewPerson_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            updateContent();

            if (controller.PersonCount > 0)
            {
                btnDeletePerson.IsEnabled = true;
                btnUp.IsEnabled = true;
                btnDown.IsEnabled = true;
                tbFirstName.IsEnabled = true;
                tbLastName.IsEnabled = true;
                tbAge.IsEnabled = true;
                tbTelephone.IsEnabled = true;
            } 
        }

        private void btnDeletePerson_Click(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
            updateContent();

            if (controller.PersonCount == 0)
            {
                btnDeletePerson.IsEnabled = false;
                btnUp.IsEnabled = false;
                btnDown.IsEnabled = false;
                tbFirstName.IsEnabled = false;
                tbLastName.IsEnabled = false;
                tbAge.IsEnabled = false;
                tbTelephone.IsEnabled = false;
            }
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            updateContent();
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            updateContent();
        }

        private void tbFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.FirstName = tbFirstName.Text;
        }

        private void tbLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.LastName = tbLastName.Text;
        }

        private void tbAge_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.Age = int.Parse(tbAge.Text);
        }

        private void tbTelephone_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.TelephoneNo = tbTelephone.Text;
        }
    }
}
