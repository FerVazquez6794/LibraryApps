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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnTouchPad_Click_1(object sender, RoutedEventArgs e)
        {
            string s = Content.ToString();
            string r = System.Windows.Controls.ContentControl.ContentProperty.Name.v); 
            txtResult.Text = s + r; 
        }

        private void FormMain_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            txtResult.Text = e.Key.ToString(); 
        }
    }
}
