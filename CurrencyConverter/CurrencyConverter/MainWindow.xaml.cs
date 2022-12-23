using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable dtCurrency;
        double input, valueFrom, valueTo, conversionRate, output;

        public MainWindow()
        {
            InitializeComponent();

            BuildDataTable();
            BindCurrency(cbo_currencyFrom);
            BindCurrency(cbo_currencyTo);
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            ClearControls();
        }

        //Currency data for ComboBox
        private void BuildDataTable()
        {
            //Initialize instance of DataTable
            dtCurrency = new DataTable();

            //Add columns: name of currency and its value
            dtCurrency.Columns.Add("Name");
            dtCurrency.Columns.Add("Value");

            //Add currencies and their values
            dtCurrency.Rows.Add("--Select--", 0);
            dtCurrency.Rows.Add("INR", 1);
            dtCurrency.Rows.Add("USD", 75);
            dtCurrency.Rows.Add("EUR", 85);
            dtCurrency.Rows.Add("SAR", 20);
            dtCurrency.Rows.Add("GBP", 5);
            dtCurrency.Rows.Add("DEM", 43);
        }

        //Populates Combo Boxes
        private void BindCurrency(ComboBox comboBox)
        {
            //ComboBox is populated with data from the DataTable
            comboBox.ItemsSource = dtCurrency.DefaultView;

            //The column values which are to be displayed in the GUI
            comboBox.DisplayMemberPath= "Name";

            //The column values that will be selected behind the scenes
            comboBox.SelectedValuePath = "Value";

            //The index of the default value ("--Select--")
            comboBox.SelectedIndex = 0;
        }

        //Resets everything
        private void ClearControls()
        {
            tb_amount.Text = string.Empty;
            cbo_currencyFrom.SelectedIndex= 0;
            cbo_currencyTo.SelectedIndex= 0;
            lbl_converted.Content = string.Empty;
            tb_amount.Focus();
        }

        //Allowed Characters
        private readonly Regex _regex = new Regex("[^0-9.]+"); //regex that matches disallowed text

        //Checks if input text is valid
        private bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        //Allows for text input or not
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private double calculateConversion()
        {
            input = double.Parse(tb_amount.Text);
            valueFrom = Convert.ToDouble(cbo_currencyFrom.SelectedValue);
            valueTo = Convert.ToDouble(cbo_currencyTo.SelectedValue);
            conversionRate = valueTo / valueFrom;

            return input * conversionRate;
        }
    }
}
