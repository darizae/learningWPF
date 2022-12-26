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
using IronPython.Hosting;
using static IronPython.Modules._ast;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Win32;
using System.IO;

namespace GC_Content_Analyzer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Microsoft.Win32.OpenFileDialog dlg;
        Nullable<bool> fileChosen;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var engine = Python.CreateEngine();
            //var module = engine.ExecuteFile("hello_world.py");
            OpenFile();
        }

        private void OpenFile()
        {
            // Create Open File Dialog
            dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text Files(*.txt)| *.txt";

            // Set initial directory
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Display OpenFileDialog by calling ShowDialog method
            fileChosen = dlg.ShowDialog();

            // Get the selected file name and display in a Label
            if (fileChosen == true)
            {
                // Open document
                string fileName = dlg.FileName;
                lblFileName.Content = fileName;

                Console.WriteLine(File.ReadAllText(dlg.FileName));
            }

            
        }
    }
}
