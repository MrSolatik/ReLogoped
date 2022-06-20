using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Logoped1
{
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
            Somthing.ItemsSource = LogopedCabEntities.GetContext().Students.ToList();
        }
        private void GoSecondPa_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new SecondPage());
        }

        private void WordPage1_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new PageForWord());
        }

        private void NewTableBtn_Click(object sender, RoutedEventArgs e)
        {
            Raspisanie raspisanie = new Raspisanie();
            raspisanie.Show();
        }

        private void InfoBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа разаработа Сурцевы Дмитрием Сергеевичем, 28.05.2022 для дипломного задания по теме: " + 
                " Разработка приложения по автоматизации деятельности логопеда в школе", "Об программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void GoRegistPage_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new RegistPage());
        }
    }
}
