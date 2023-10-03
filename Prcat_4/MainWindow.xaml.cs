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

namespace Задание_2
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
        bool available = true;
        private void ColorButton(object sender)
        {
            if (available)
            {
                var color = (sender as RadioButton).Tag as SolidColorBrush;
                if (color != null)
                {
                    Text_label.Background = color;
                }
            }
        }
        private void RadioButton_red_Checked(object sender, RoutedEventArgs e)
        {
            ColorButton(sender);
        }

        private void RadioButton_blue_Checked(object sender, RoutedEventArgs e)
        {
            ColorButton(sender);
        }

        private void RadioButton_green_Checked(object sender, RoutedEventArgs e)
        {
            ColorButton(sender);
        }

        private void RadioButton_ordinary_Checked(object sender, RoutedEventArgs e)
        {
            if (available)
            {
                Text_label.FontWeight = FontWeights.Normal;
            }
        }

        private void RadioButton_semiBold_Checked(object sender, RoutedEventArgs e)
        {
            if (available)
            {
                Text_label.FontWeight = FontWeights.SemiBold;
            }
        }

        private void RadioButton_Bold_Checked(object sender, RoutedEventArgs e)
        {
            if (available)
            {
                Text_label.FontWeight = FontWeights.Bold;
            }
        }

        private void RadioButton_available_Checked(object sender, RoutedEventArgs e)
        {
            available = true;
            Text_label.IsEnabled = true;
        }

        private void RadioButton_unavailable_Checked(object sender, RoutedEventArgs e)
        {
            available = false;
            Text_label.IsEnabled = false;
        }

        private void Text_label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        { 
        }
    }
}
