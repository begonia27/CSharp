using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Bluetooth;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Selection
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage: Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.FirstDate.SelectedDate = DateTime.Today;
            this.SecondDate.SelectedDate = DateTime.Today;
        }

        private void CompareClick(object sender, RoutedEventArgs e)
        {
            int diff = DateCompare(FirstDate.Date.LocalDateTime, SecondDate.Date.LocalDateTime);
            Info.Text = "";
            Show("FirstDate == secondDate", diff == 0);
            Show("FirstDate != secondDate", diff != 0);
            Show("FirstDate <  secondDate", diff <  0);
            Show("FirstDate <= secondDate", diff <= 0);
            Show("FirstDate >  secondDate", diff >  0);
            Show("FirstDate >= secondDate", diff >= 0);
        }

        private void Show(string exp, bool result)
        {
            Info.Text += exp;
            Info.Text += " : " + result.ToString();
            Info.Text += "\n";
        }

        private int DateCompare(DateTime leftHandSide, DateTime rightHandSide)
        {
            int result = 0;

            if (leftHandSide.Year < rightHandSide.Year)
            {
                result = -1;
            }
            else if (leftHandSide.Year > rightHandSide.Year)
            {
                result = 1;
            }
            else if (leftHandSide.Month < rightHandSide.Month)
            {
                result = -1;
            }
            else if (leftHandSide.Month > rightHandSide.Month)
            {
                result = 1;
            }
            else if (leftHandSide.Day < rightHandSide.Day)
            {
                result = -1;
            }
            else if (leftHandSide.Day > rightHandSide.Day)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            return result;
        }
    }
}
