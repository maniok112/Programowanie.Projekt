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

namespace Projekt
{
    /// <summary>
    /// Logika interakcji dla klasy Baza.xaml
    /// </summary>
    public partial class Baza : Window
    {
        public Baza()
        {
            InitializeComponent();
        }

        private void BtnSprawdz_Click(object sender, RoutedEventArgs e)
        {
            // Tutaj Dodadać Sql Connection i Wyswietlać w DataGrind
        }

        private void Btnpowrot_Click(object sender, RoutedEventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }
    }
}
