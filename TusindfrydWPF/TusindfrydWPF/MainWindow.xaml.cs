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

namespace TusindfrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FlowerSort> flowerSorts;

        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog createFlowerSort = new();
            // Question mark is needed
            bool? result = createFlowerSort.ShowDialog();

            if (result == true)
            {
                // Take all information from the createflower class and make a new instance of flower
                FlowerSort flower = new();
                flower.Name = createFlowerSort.Name;
                flower.PicturePath = createFlowerSort.PicturePath;
                flower.ProductionTime = createFlowerSort.ProductionTime;
                flower.HalfLifeTime = createFlowerSort.HalfLifeTime;
                flower.Size = createFlowerSort.Size;
                flowerSorts.Add(flower);
            }
            else
            {
                return;
            }

            // Update the textblock to show list of flowers
            if (flowerSorts.Count > 0)
            {
                tbFlowerSorts.Text = "";
                foreach (var flowerSort in flowerSorts)
                {
                    tbFlowerSorts.Text += $"{flowerSort.Name}\n";
                }
            }
        }
    }
}
