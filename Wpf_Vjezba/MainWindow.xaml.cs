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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Vjezba
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

        private void btnDodavanjeStudenta_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DodavanjeStudenta ds = new DodavanjeStudenta();
            ds.ShowDialog();
            this.Show();
        }

        private void btnIzlaz_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPregledStudenata_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PregledStudenata ps = new PregledStudenata();
            ps.ShowDialog();
            this.Show();
        }

        private void btnPlaner_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Planer p = new Planer();
            p.ShowDialog();
            this.Show();
        }
    }
}
