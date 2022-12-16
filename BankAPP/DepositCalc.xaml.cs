using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace BankAPP
{
    /// <summary>
    /// Логика взаимодействия для DepositCalc.xaml
    /// </summary>
    public partial class DepositCalc : Window
    {
        public DepositCalc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DepositComparisnn depositComparisnn = new DepositComparisnn();
            depositComparisnn.Show();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = " ", NumberDecimalDigits = 0 };
            tb_amount.Text = ((Slider)sender).Value.ToString("n", nfi);
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = " ", NumberDecimalDigits = 0 };
            tb_term.Text = ((Slider)sender).Value.ToString("n", nfi);
        }

        private void Slider_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = " ", NumberDecimalDigits = 0 };
            tb_replenishment.Text = ((Slider)sender).Value.ToString("n", nfi);
        }
    }
}
