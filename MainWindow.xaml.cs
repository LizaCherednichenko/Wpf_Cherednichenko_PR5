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

namespace Wpf_Cherednichenko_PR5
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

        private void pict1_Click(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri("Pictures/kitty1.jpg", UriKind.Relative));
        }

        private void pict2_Click(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri("Pictures/kitty2.jpg", UriKind.Relative));
        }

        private void pict3_Click(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri("Pictures/kitty3.jpg", UriKind.Relative));
        }

        private void pict4_Click(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri("Pictures/kitty4.jpg", UriKind.Relative));
        }

        private void pict5_Click(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri("Pictures/kitty5.jpg", UriKind.Relative));
        }

        private void pict6_Click(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri("Pictures/kitty6.jpg", UriKind.Relative));
        }

        private void pict7_Click(object sender, RoutedEventArgs e)
        {
            img1.Source = new BitmapImage(new Uri("Pictures/kitty7.jpg", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string a = textbox1.Text;
            img1.Source = new BitmapImage(new Uri(a));
        }
    }
    }

