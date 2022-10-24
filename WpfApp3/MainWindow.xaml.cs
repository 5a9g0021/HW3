using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string[] input = new string[textbox1.Text.Length];
            int q = 0, u = 0, y = 0;
            string[] items = new string[100];
            string inputstring = textbox1.Text;
            int[] number = new int[100];
            char[] symbol = new char[] { ' ', '.', ',' };
            string[] text = inputstring.Split(symbol, StringSplitOptions.RemoveEmptyEntries);
            textbox2.Text = " ";
            foreach (var n in text)
            {
                input[q] = n;
                q++;
            }
            foreach (var n in input)
            {
                int index = Array.IndexOf(items, n);
                if (index != -1)
                {
                    var x = Array.FindIndex(items, x => x == n);
                    number[x]++;
                }
                else
                {
                    items[u] = n;
                    u++;
                }
            }
            foreach (var n in number)
            {
                number[y]++;
                y++;
            }
            y = 0;
            for (int i = 0; i < u; i++)
            {
                textbox2.Text += $"你所輸入的{items[y]}:出現了{number[y]}次\n";
                y++;
            }
        }
    }
}