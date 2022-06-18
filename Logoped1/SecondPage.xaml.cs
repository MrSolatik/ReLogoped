using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Logoped1
{
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
            //DBLogo.ItemsSource = LogopedCabEntities.GetContext().RechevayKartas.ToList();
        }

        private void DelBtn1_Click(object sender, RoutedEventArgs e)
        {
            var ItemsForRemoving = DBLogo.SelectedItems.Cast<RechevayKarta>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить данные {ItemsForRemoving.Count()} элементы?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    LogopedCabEntities.GetContext().RechevayKartas.RemoveRange(ItemsForRemoving);
                    LogopedCabEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    DBLogo.ItemsSource = LogopedCabEntities.GetContext().RechevayKartas.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void AddBtn1_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new AddPage(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                LogopedCabEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DBLogo.ItemsSource = LogopedCabEntities.GetContext().RechevayKartas.ToList();
            }
        }

        private void EditBtn1_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new AddPage((sender as Button).DataContext as RechevayKarta));
        }
    }
}
