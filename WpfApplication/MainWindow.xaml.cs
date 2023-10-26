using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)

        {

            TextBox textBox = (TextBox)sender;

            MessageBox.Show(textBox.Text);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == string.Empty)

            {

                MessageBox.Show("Вы не ввели 1-е число");
            }
            else if (TextBox2.Text == string.Empty)
            {

                MessageBox.Show("Вы не ввели 2-е число");

            }
            else if (TextBox3.Text == string.Empty)
            {

                MessageBox.Show("Вы не ввели 3-е число");

            }
            else
            {
                int a=0;
                int b =0;
                int c =0;
                int sum = 0;
                int mul = 0;
                a = Convert.ToInt32(TextBox1.Text);    
                b = Convert.ToInt32(TextBox2.Text);
                c = Convert.ToInt32(TextBox3.Text);
                sum = a + b + c;
                mul = a * b * c;
                MessageBox.Show(sum.ToString());
                MessageBox.Show(mul.ToString());
            }

        }
    }
}
