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

namespace Wandrechner
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double breite = Double.Parse(tb_breite.Text);
            double laenge = Double.Parse(tb_laenge.Text);
            double hoehe = Double.Parse(tb_hoehe.Text);

            bool istTragend = (bool)cb_istTragend.IsChecked;

            string material = cbo_material.Text;

            Wand wandPlan = new Wand();
            wandPlan.breite = breite;
            wandPlan.hoehe = hoehe;
            wandPlan.laenge= laenge;
            wandPlan.material= material;
            wandPlan.istTragend= istTragend;

            wandPlan.BerechneSchalungsflaeche();
            wandPlan.BerechneBewehrungsmenge();

            lbl_ausgabe.Content = $"Ausgabe {wandPlan.GebeWandinfosAus()}";
        }
    }
}
