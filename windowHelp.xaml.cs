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
using System.Windows.Shapes;

namespace SHuTiMEv2
{
    /// <summary>
    /// Логика взаимодействия для windowHelp.xaml
    /// </summary>
    public partial class windowHelp : Window
    {
        public windowHelp()
        {
            InitializeComponent();
        }
        
        private void tbxHour_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxHour.Text == "") { tbxHour.Text = "0"; }
            double decimalHour = Convert.ToDouble(tbxHour.Text);
            tbxSec.Text = Convert.ToString(decimalHour * 3600);
            
        }

        private void tbxSec_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxSec.Text == "") { tbxSec.Text = "0"; }
            double decimalSec = Convert.ToDouble(tbxSec.Text);
            tbxHour.Text = Convert.ToString(decimalSec / 3600);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
