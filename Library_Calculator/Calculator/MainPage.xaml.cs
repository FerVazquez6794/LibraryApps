using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Calculator
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public long Number1 { get; set;  }
        public long Number2 { get; set; }
        public string  Operation { get; set; }

        public MainPage()
        {
            Number1 = 0;
            Number2 = 0;
            Operation = ""; 
            this.InitializeComponent();

        }

        private void ButtonNumberClick(object sender, RoutedEventArgs e)
        {
            ContentControl contentControl = (ContentControl)sender;
            string button = contentControl.Content.ToString(); 
            int inputValue = Convert.ToInt32(button);
                

            if(Operation=="")
            {
                Number1 = (Number1 * 10) + inputValue;
                txtResult.Text = Number1.ToString(); 
            }
            else
            {
                Number2 = (Number2 * 10) + inputValue;
                txtResult.Text = Number2.ToString();
            }
        }

     
    }
}
