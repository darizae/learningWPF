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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string strZahl;
        private string strLetzteOperation;
        private double dblErgebnis;

        public MainWindow()
        {
            InitializeComponent();

            strZahl = "";
            strLetzteOperation = "";
            dblErgebnis = 0.0;


        }

        private void btn_eq_Click(object sender, RoutedEventArgs e)
        {
            strZahl = eingabe_tf.Text;
            double eingabe = Double.Parse(strZahl);
            berechnen(eingabe);
            updateGUI();
        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            resetGUI();
        }

        public void berechnen(double value)
        {
            if (rb_root.IsChecked == true)
            {
                dblErgebnis = Math.Sqrt(value);
            }

            if (rb_pot.IsChecked == true)
            {
                dblErgebnis = Math.Exp(value);
            }

            if (rb_sin.IsChecked == true)
            {
                dblErgebnis = Math.Sin(value);
            }

            if (rb_tan.IsChecked == true)
            {
                dblErgebnis = Math.Tan(value);
            }
            
            strLetzteOperation += dblErgebnis;
        }

        public void resetGUI()
        {
            list_box.Items.Clear();
            eingabe_tf.Text = "";
            ausgabe_lb.Content = "0.0";
            dblErgebnis = 0;
        }

        public void updateGUI()
        {
            list_box.Items.Add(dblErgebnis);
            ausgabe_lb.Content = dblErgebnis;
            eingabe_tf.Text = dblErgebnis.ToString();
        }
    }

}
