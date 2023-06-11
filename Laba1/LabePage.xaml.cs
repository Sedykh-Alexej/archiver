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

namespace Laba1
{
    /// <summary>
    /// Логика взаимодействия для LabePage.xaml
    /// </summary>
    public partial class LabePage : Page
    {
        public string filename = null;
        Huffman huffman = new Huffman();

        public LabePage()
        {
            InitializeComponent();
        }

        private void Выход(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Задание_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Text documents (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                // Open document
                filename = dialog.FileName;
                file.Text = "Вы выбрали файл: "+ filename;
            }
            
        }

        private void CompressFile(object sender, RoutedEventArgs e)
        {
            if (filename == null)
            {
                MessageBox.Show("Не введен файл");
            }
            else
            {             
                huffman.CompressFile(filename, filename+".huf");
            }
        }

        private void DeCompressFile(object sender, RoutedEventArgs e)
        {
            huffman.DeCompressFile(filename, filename +".txt");
        }
    }
}
