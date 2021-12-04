using System;
using System.Windows;

namespace AYD
{
    public partial class AreYouDumb : Window
    {
        static readonly Random rnd = new();
        public AreYouDumb()
        {
            InitializeComponent();
        }
        private void Button1Click(object sender, RoutedEventArgs e)
        {
            Button1.Visibility = Visibility.Hidden;
            Button2.Visibility = Visibility.Hidden;
            TextBlock1.Visibility = Visibility.Hidden;
            TextBlock2.Visibility = Visibility.Visible;
        }
        private void Button2Click(object sender, RoutedEventArgs e)
        {
            Button2.Margin = new(rnd.Next(20, 300), rnd.Next(-50, 270), 0, 0);
        }
    }
}
