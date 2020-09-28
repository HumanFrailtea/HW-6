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

namespace HW_6
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x, y;
            double BMI;
            String Weight = one.Text;
            String Height = two.Text;
            x = Int32.Parse(Weight);
            y = Int32.Parse(Height);

            BMI = (x * 720) / (y*y);
            

            if (BMI < 15)
            {
                Canvas.Background = Brushes.Blue;
                MessageBox.Show("Your BMI is : " + BMI + "." + "Your BMI is below healthy range");
            }
            else if (BMI >= 15 && BMI <= 26)
            {
                Canvas.Background = Brushes.Green;
                MessageBox.Show("Your BMI is : " + BMI + "." + "Your BMI is in health range.");
            }
            else if (BMI > 26)
            {
                Canvas.Background = Brushes.Yellow;
                MessageBox.Show("Your BMI is : " + BMI + "." + "Your BMI is above health range.");
        }
    }
    }
}
