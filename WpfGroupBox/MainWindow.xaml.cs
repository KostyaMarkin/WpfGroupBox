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

namespace WpfGroupBox
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Checked_RadioButton()
        {
            if (radBtnGreen.IsChecked == true) groupBoxColor.Background = new SolidColorBrush(Colors.Green);
            else if (radBtnYellow.IsChecked == true) groupBoxColor.Background = new SolidColorBrush(Colors.Yellow);
            else if (radBtnOrange.IsChecked == true) groupBoxColor.Background = new SolidColorBrush(Colors.Orange);
        }

        private void radBtnGreen_Checked(object sender, RoutedEventArgs e)
        {
            Checked_RadioButton();
        }

        private void radBtnOrange_Checked(object sender, RoutedEventArgs e)
        {
            Checked_RadioButton();
        }

        private void radBtnYellow_Checked(object sender, RoutedEventArgs e)
        {
            Checked_RadioButton();
        }
    }
}
