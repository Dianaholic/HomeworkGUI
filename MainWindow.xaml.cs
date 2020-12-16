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

namespace homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(txtinput.Text);
            int output = int.Parse(txtoutput.Text);
            int want = int.Parse(txtwant.Text);
            int rairub = input - output;
            int kebmoney = want / output;
            txtfinish.Text = kebmoney.ToString();
            MessageBox.Show("ระบบได้คำนวณจำนวนเงินของท่านแล้วเรียบร้อย");
        }
    }
}
