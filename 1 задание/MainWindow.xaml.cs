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

namespace _227_2
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
        void BtnOK_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(TbNumberA.Text);
            double B = Convert.ToDouble(TbNumberB.Text);
            if (A > B) { A = A % B; }
            else { TextBlockAnswer.Text = $"вы ввели числа неправильно"; }
            TextBlockAnswer.Text = $"{A}m";
        }
    }
}
