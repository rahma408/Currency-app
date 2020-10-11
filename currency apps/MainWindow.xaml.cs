using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace currency_apps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CurrencyController currency;

        public MainWindow()
        {
            InitializeComponent();
            currency = new CurrencyController();
        }

        private void Button_Hitung_Click(object sender, RoutedEventArgs e)
        {
            var nominalinput = Input_textBox.Text;
            var result = "invalid";
            if (currency.isAllowed(nominalinput))
            {
                result = currency.usdToIdr(nominalinput);
            }
            resultlabel.Content = result;
        }
    }
}
