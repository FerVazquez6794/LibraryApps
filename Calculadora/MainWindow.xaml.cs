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

        private void KeyboardInput()
        {
            string input = "";
        }

        private void btnNumSiete_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.NumPad7);
        }

        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnPorcent_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.Divide);
        }

        private void btnNumOcho_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.NumPad8);
        }

        private void btnNumNueve_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.NumPad9);
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.Multiply); 
        }

        private void btnNumCuatro_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.NumPad4); 
        }

        private void btnNumCinco_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.NumPad5);
        }

        private void btnNumSeis_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.NumPad6);
        }

        private void btnResta_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.Subtract);
        }

        private void btnNumUno_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.NumPad1);
        }

        private void btnNumDos_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.NumPad2);
        }

        private void btnNumTres_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.NumPad3);
        }

        private void btnSumar_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.Add); 
        }

        private void btnNumCero_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.NumPad0); 
        }

        private void btnPunto_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.Decimal); 
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            KeyPress(Key.Enter); 
        }

        private void txtResult_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPress(e.Key); 
        }

        private void KeyPress (Key key)
        {
            string result = ""; 
            switch(key)
            {
                case Key.NumPad0 | Key.D0:
                    result = "0";
                    break;
                case Key.NumPad1| Key.D1:
                    result = "1";
                    break;
                case Key.NumPad2| Key.D2:
                    result = "2";
                    break;
                case Key.NumPad3| Key.D3:
                    result = "3";
                    break;
                case Key.NumPad4| Key.D4:
                    result = "4";
                    break;
                case Key.NumPad5| Key.D5:
                    result = "5";
                    break;
                case Key.NumPad6| Key.D6:
                    result = "6";
                    break;
                case Key.NumPad7| Key.D7:
                    result = "7";
                    break;
                case Key.NumPad8| Key.D8:
                    result = "8";
                    break;
                case Key.NumPad9| Key.D9:
                    result = "9";
                    break;
                case Key.Multiply:
                    result = "*";
                    break;
                case Key.Add:
                    result = "+";
                    break;
                case Key.Subtract:
                    result = "-";
                    break;
                case Key.Decimal:
                    result = ".";
                    break;
                case Key.Divide:
                    result = "/";
                    break;
                case Key.Enter:
                    result = "=";
                    break; 
                default:
                    result = "Ingresa solo números";
                    break;
            }
            txtResult.Text = result; 
        }

        

        private void btnPorcent_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtResult_KeyUp(object sender, KeyEventArgs e)
        {
            KeyPress(e.Key);  
        }
    }
}
