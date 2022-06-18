using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace Logoped1
{
    public partial class Raspisanie : Window
    {
        public Raspisanie()
        {
            InitializeComponent();
        }
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //openFileDialog.InitialDirectory = @"C:\Users\dimas\Desktop\Документы\Протоколы_к_речевой_карте\";
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt|C# файл (*.cs)|*.cs | Word файл(*.docx)|*.docx";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            MessageBox.Show("Данные успешно сохранены!","Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
