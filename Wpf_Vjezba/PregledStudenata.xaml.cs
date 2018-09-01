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
    /// Interaction logic for PregledStudenata.xaml
    /// </summary>
    public partial class PregledStudenata : Window
    {
        public PregledStudenata()
        {
            string nazivResursa;

            InitializeComponent();

            foreach (Student s in Repo.Studenti)
            {
                if (s.Redovan == true)
                {
                    nazivResursa = "brushRedovan";
                }
                else
                {
                    nazivResursa = "brushIzvanredan";
                }

                Label lbl = new Label
                {
                    Content = $"{s.Ime} {s.Prezime} ({s.Godine})",
                    Background = (Brush)FindResource(nazivResursa)
                };
                pnlStudenti.Children.Add(lbl);
            }


        }
    }
}
