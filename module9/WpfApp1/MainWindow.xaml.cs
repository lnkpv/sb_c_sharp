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

namespace WpfApp1
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

        static string ReverseWords(string text)
        {
            string[] words = SplitText(text);
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        static string[] SplitText(string text)
        {
            char[] separator = new char[] { ' ' };
            return text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }

        private void ButtonSplit_Click(object sender, RoutedEventArgs e)
        {
            string input = TextBoxSplit.Text;
            if (!string.IsNullOrWhiteSpace(input))
            {
                var words = SplitText(input);
                ListBoxWords.Items.Clear();
                foreach (var word in words)
                {
                    ListBoxWords.Items.Add(word);
                }
            }
            else
            {
                MessageBox.Show("Введите текст для разделения на слова.");
            }
        }

        private void ButtonReverse_Click(object sender, RoutedEventArgs e)
        {
            string input = TextBoxReverse.Text;
            if (!string.IsNullOrWhiteSpace(input))
            {
                LabelReversed.Content = ReverseWords(input);
            }
            else
            {
                MessageBox.Show("Введите текст для перестановки слов.");
            }
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Foreground == Brushes.Gray)
            {
                textBox.Text = string.Empty;
                textBox.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "TextBoxSplit")
                    textBox.Text = "Введите предложение для разделения на слова";
                else if (textBox.Name == "TextBoxReverse")
                    textBox.Text = "Введите предложение для перестановки слов";

                textBox.Foreground = Brushes.Gray;
            }
        }
    }
}
