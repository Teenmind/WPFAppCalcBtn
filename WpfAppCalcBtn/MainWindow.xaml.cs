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

namespace WpfAppCalcBtn
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

        public int a = 0;
        public int b = 0;
        char op = '0';

        public static int calc(int a, int b, char op)
        {
            int res = 0;
            if (op == '+')
                res = a + b;
            if (op == '-')
                res = a - b;
            if (op == '*')
                res = a * b;
            if (op == '/')
                if (b == 0)
                    throw new DivideByZeroException();
                else
                    res = a / b;
            return res;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = txtField.Text + 1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = txtField.Text + 2;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = txtField.Text + 3;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = txtField.Text + 4;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = txtField.Text + 5;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = txtField.Text + 6;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = txtField.Text + 7;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = txtField.Text + 8;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = txtField.Text + 9;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtField.Text = txtField.Text + 0;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(txtField.Text);
            txtField.Clear();
            op = '+';
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(txtField.Text);
            txtField.Clear();
            op = '-';
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(txtField.Text);
            txtField.Clear();
            op = '*';
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(txtField.Text);
            txtField.Clear();
            op = '/';
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            op = '0';
            txtField.Clear();
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            b = Convert.ToInt32(txtField.Text);
            txtField.Clear();
            try
            {
                int res = calc(a, b, op);
                txtField.Text = Convert.ToString(res);
            }
            catch (DivideByZeroException)
            {
                txtField.Text = "∞";
            }
        }
    }
}
