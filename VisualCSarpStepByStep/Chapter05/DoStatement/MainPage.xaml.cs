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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DoStatement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage: Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ShowStepsClick(object sender, RoutedEventArgs e)
        {
            const int bin = 2;
            const int oct = 8;
            const int hex = 16;
            
            int amount = int.Parse(Number.Text);
            
            // initialize with a empty strings
            Steps.Text = "";
            string current = "";
            
            do
            {
                int nextDigit = amount % oct;
                amount /= oct;
                
                int digitCode = 0;

                if (nextDigit >= 0 && nextDigit <= 9)
                {
                     digitCode = nextDigit + '0';
                }
                else if (nextDigit >= 10 && nextDigit <= 15)
                {
                     digitCode = nextDigit + 55;
                }
                
                char digit = Convert.ToChar(digitCode);
                current += digit;
                Steps.Text += current + '\n';
            } while (amount != 0);
        }
    }
}
