using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Logoped1
{
    public partial class AddPage : Page
    {
        private RechevayKarta _currentKarta = new RechevayKarta();
        public AddPage(RechevayKarta selectedKarta)
        {
            if (selectedKarta != null)
                _currentKarta = selectedKarta;


            InitializeComponent();
            DataContext = _currentKarta;
            SelectItem.ItemsSource = LogopedCabEntities.GetContext().RechevayKartas.ToList();
        }

        private void SaveBtn1_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentKarta.Class))
                errors.AppendLine("Введите класс!");

            /*if (_currentKarta.FIO != null)
            {
                bool isValid = PoleFIO.Text.Length < 10;
                MessageBox.Show("Недостаточно символов");
                return;
            }
                errors.AppendLine("Введите имя");*/

            if (_currentKarta.SocSreda == null)
                errors.AppendLine("Введите данные о социальной среде!");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentKarta.ID == 0)
                LogopedCabEntities.GetContext().RechevayKartas.Add(_currentKarta);
            try
            {
                LogopedCabEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                FrameClass.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
