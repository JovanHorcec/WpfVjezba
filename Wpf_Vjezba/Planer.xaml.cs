using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Wpf_Vjezba
{
    /// <summary>
    /// Interaction logic for Planer.xaml
    /// </summary>
    public partial class Planer : Window
    {
        public Planer()
        {
            InitializeComponent();

            lblDan.Content = DateTime.Now.ToString("dddd");
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(txtSatPocetka.Text, out int satPocetka);
            int.TryParse(txtMinutePocetka.Text, out int minutePocetka);
            int.TryParse(txtSatKraja.Text, out int satKraja);
            int.TryParse(txtMinuteKraja.Text, out int minuteKraja);

            string vrijeme = $"  {satPocetka:00}:{minutePocetka:00} - {satKraja:00}:{minuteKraja:00}";

            ListBoxItem selectedItem = (ListBoxItem)listPredmeti.SelectedItem;
            string predmet = selectedItem.Content.ToString();

            Label plan = new Label
            {
                Content = $"{predmet}\n{vrijeme}",
                Padding = new Thickness(15),
                Margin = new Thickness(5),
                FontSize = 25,
                Background = (Brush)FindResource("brushRedovan")
            };

            pnlPlanovi.Children.Add(plan);
        }

        private void btnOcisisti_Click(object sender, RoutedEventArgs e)
        {
            pnlPlanovi.Children.Clear();
        }
    }
}
