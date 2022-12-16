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

namespace BankAPP
{
    /// <summary>
    /// Логика взаимодействия для DepositComparisnn.xaml
    /// </summary>
    public partial class DepositComparisnn : Window
    {
        public DepositComparisnn()
        {
            InitializeComponent();
        }

        private void bt_openstable_Click(object sender, RoutedEventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        private void btn_openoptimal_Click(object sender, RoutedEventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        private void bt_openstandart_Click(object sender, RoutedEventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
        }
    }
}
