using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Lab1Sophie_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rhombus _rhombus;
        private int _countCalculate = 0;
        public MainWindow()
        {
            InitializeComponent();
            _rhombus = new Rhombus();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(tbSideLength.Text, out double sideLength))
            {
                _rhombus.SideLength = sideLength;
            }
            else if(tbSideLength.Text.Length == 0)
            {
                _rhombus = new Rhombus();
            }
            else
            {
                MessageBox.Show("Number is not valid!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBox.Show($"Result after calculating: {_rhombus.CalculateArea()}", "Result!", MessageBoxButton.OK, MessageBoxImage.Information);
            _countCalculate++;

        }

        private void btnCalculatePrev_Click(object sender, RoutedEventArgs e)
        {
            if (_countCalculate > 0)
            {
                MessageBox.Show($"Result after calculating: {_rhombus.CalculateArea()}", "Result!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No previous calculation!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
