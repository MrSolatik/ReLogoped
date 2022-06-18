using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Forms;

namespace Logoped1
{
    public partial class RegistPage : Page
    {
        public RegistPage()
        {
            InitializeComponent();
        }
        private void txbPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (psbPass.Password != txbPass.Text)
            {
                RegistBtn.IsEnabled = false;
                psbPass.Background = Brushes.LightCoral;
                psbPass.BorderBrush = Brushes.Red;
            }
            else
                RegistBtn.IsEnabled = true;
            psbPass.Background = Brushes.LightGreen; ;
            psbPass.BorderBrush = Brushes.Green;
        }

        private void RegistBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AppConnect.model0db.Users.Count(x => x.Login == txbLogin.Text) > 0)
            {
                System.Windows.MessageBox.Show("Пользователь с таким логином уже зарегистрирован", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                User user0bj = new User()
                {
                    Login = txbLogin.Text,
                    Name = txbName.Text,
                    Password = txbPass.Text,
                    IdRole = 1
                };
                AppConnect.model0db.Users.Add(user0bj);
                AppConnect.model0db.SaveChanges();
                System.Windows.MessageBox.Show("Данные успешно добавлены!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                System.Windows.MessageBox.Show("Ошибка при добавлении", "Notification", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            DialogResult result = System.Windows.Forms.MessageBox.Show("Пользователь успешно создан! Преступить к работе?", "Внимание",
                (MessageBoxButtons)MessageBoxButton.YesNo, (MessageBoxIcon)MessageBoxImage.Question);
            if (result == DialogResult.Yes)
                FrameClass.MainFrame.Navigate(new Menu());
            if(result == DialogResult.No)
            {
                FrameClass.MainFrame.Navigate(new LoginPage());
            }
        }
    }
}
