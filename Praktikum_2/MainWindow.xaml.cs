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

namespace Praktikum_2
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

        private int getNumber()
        {
            try
            {
                return int.Parse(TextBoxNumber.Text);
            }
            catch
            {
                MessageBox.Show("Не правильное число!");
                return -1;
            }
            
        }

        private bool multipleThree(int number)
        {
            return number % 3 == 0;
        }

        private string isEven(int number)
        {
            return number % 2 == 0 ? "Чётное" : "Нечётное";
        }

        private int sumNumber(int number)
        {
            int sum = 0;
            char[] arrayNumber = number.ToString().ToArray();
            foreach(char num in arrayNumber)
            {
                sum += num - '0';
            }
            return sum;
        }

        private int multipleNumber(int number)
        {
            int multi = 1;
            char[] arrayNumber = number.ToString().ToArray();
            foreach (char num in arrayNumber)
            {
                multi *= num - '0';
            }
            return multi;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = getNumber();
            if(number != -1)
            {
                multiThreeRes.Text = multipleThree(number).ToString();
                evenRes.Text = isEven(number);
                sumRes.Text = sumNumber(number).ToString();
                multRes.Text = multipleNumber(number).ToString();
            }
        }

        private void TextBoxNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try 
            {
                int number = int.Parse(textBox.Text);
                if (textBox.Text.Length > 2)
                {
                    MessageBox.Show("Нужно ввести двухзначное число!");
                }
            }
            catch
            {
                MessageBox.Show("Нужно ввести двухзначное число!");
            }
        }
    }
}
