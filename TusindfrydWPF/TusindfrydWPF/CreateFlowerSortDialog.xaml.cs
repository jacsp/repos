using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public int ProductionTime { get; set; }
        public int HalfLifeTime { get; set; }
        public int Size { get; set; }

        bool nameEntered = false;
        bool picturePathEntered = false;
        bool productionTimeEntered = false;
        bool halfTimeEntered = false;
        bool sizeEntered = false;

        public CreateFlowerSortDialog()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Name = tbName.Text;
            PicturePath = tbPicturePath.Text;
            try
            {
                ProductionTime = int.Parse(tbProductionTime.Text);
                HalfLifeTime = int.Parse(tbHalfTime.Text);
                Size = int.Parse(tbSize.Text);
            }
            catch (Exception ex)
            {

            }

            DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            enableOkBtnCheck();
            if (tbName.Text.Length > 0)
            {
                nameEntered = true;
            }
        }

        private void tbPicturePath_TextChanged(object sender, TextChangedEventArgs e)
        {
            enableOkBtnCheck();
            if (tbPicturePath.Text.Length > 0)
            {
                picturePathEntered = true;
            }

            try
            {
                // Create a new bitmap image to create a path
                BitmapImage bitMapImage = new();
                bitMapImage.BeginInit();
                bitMapImage.UriSource = new(tbPicturePath.Text, UriKind.Absolute);
                bitMapImage.EndInit();

                imgFlower.Source = bitMapImage;
            }
            catch (Exception ex)
            {

            }
        }

        private void tbProductionTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            enableOkBtnCheck();
            if (tbProductionTime.Text.Length > 0)
            {
                productionTimeEntered = true;
            }
        }

        private void tbHalfTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            enableOkBtnCheck();
            if (tbHalfTime.Text.Length > 0)
            {
                halfTimeEntered = true;
            }
        }

        private void tbSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            enableOkBtnCheck();
            if (tbSize.Text.Length > 0)
            {
                sizeEntered = true;
            }
        }

        private void enableOkBtnCheck()
        {
            // Test if all textboxes have text in them
            if (nameEntered && picturePathEntered && productionTimeEntered && halfTimeEntered && sizeEntered) btnOk.IsEnabled = true;
            else btnOk.IsEnabled = false;
        }
    }
}
