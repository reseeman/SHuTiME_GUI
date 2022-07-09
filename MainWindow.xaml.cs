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

namespace SHuTiMEv2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.tbxTime.PreviewTextInput += new TextCompositionEventHandler(TbxInt_PreviewTextInput);
        }

        void TbxInt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", $"/c shutdown -s -f -t {tbxTime.Text}");
            MessageBox.Show("Автовыключение запланировано!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", $"/c shutdown -a");
            MessageBox.Show("Автовыключение отменено!", "Отмена", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            windowHelp winHelp = new windowHelp();
            winHelp.Show();
        }
    }
}
