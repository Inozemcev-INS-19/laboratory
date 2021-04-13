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

namespace laba_7
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TextBoxX.Text);
            double y = Convert.ToDouble(TextBoxY.Text);
            int N = Convert.ToInt32(TextBoxN.Text);
            int K = Convert.ToInt32(TextBoxK.Text);
            double z = 0;
            for (int i = 1; i <= N; i++) {
                for (int j = 1; j <= K; j++) {
                    z = (Math.Sin(Math.Pow(y, i)) + i * x)/((i+1)*j);
                }
            }

            TextBoxAnswer.Text = z.ToString("0.00");
        }

    }
}
