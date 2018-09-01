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
using System.Windows.Shapes;

namespace Wpf_Vjezba
{
    /// <summary>
    /// Interaction logic for DodavanjeStudenta.xaml
    /// </summary>
    public partial class DodavanjeStudenta : Window
    {
        private StudentViewModel viewModel;
        
        public DodavanjeStudenta()
        {
            InitializeComponent();
            Student student = StudentService.GetStudent();

            viewModel = new StudentViewModel(student);

            DataContext = viewModel;
        }

        private void btnPovecaj_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Godine++;
        }

        private void btnSmanji_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Godine--;
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            Repo.Studenti.Add(viewModel.Student);
            btnOdustani_Click(null, null);
        }
    }
}
