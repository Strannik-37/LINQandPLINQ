using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace LinqAndPlinq
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

        Massiv massiv = new Massiv();
        private void btGenerate_Click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(tbN.Text);
            massiv.Generate(N);
            tbGenerate.Text = "";
           foreach (string element in massiv.mass)
           {
               tbGenerate.Text = tbGenerate.Text + element + '\n';
           }
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            tbRezult.Text = "";
            sw.Restart();
            string[] result = GetRezult();
            sw.Stop();
            foreach (string element in result)
            {
                tbRezult.Text = tbRezult.Text + element + '\n';
            }
            tbTime.Text = Convert.ToString(sw.Elapsed);
        }

        private string[] GetRezult()
        {
            switch (cmbAction.SelectedIndex)
            {
                case 0:
                    return massiv.EvenNumbers();
                case 1:
                    return massiv.EvenNumbers_Parallel();
                case 2:
                    return massiv.OddNumbers();
                case 3:
                    return massiv.OddNumbers_Parallel();
                case 4:
                    return massiv.SummUpperSix();
                case 5:
                    return massiv.SummUpperSix_Parallel();
                case 6:
                    return massiv.SumDigitsThirteen();
                case 7:
                    return massiv.SumDigitsThirteen_Parallel();
                default:
                    return massiv.EvenNumbers();
            }
        }
    }
}
