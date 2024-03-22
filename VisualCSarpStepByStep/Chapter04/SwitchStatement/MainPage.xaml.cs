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

namespace SwitchStatement
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

        private void CopyClick(object sender, RoutedEventArgs e)
        {
            Target.Text = "";
            string from = Source.Text;
            for (int i = 0; i != from.Length; i++)
            {
                char current = from[i];
                CopyOne(current);
            }
        }

        // private void CopyOne(char current)
        // {
        //     switch (current)
        //     {
        //         case '<' :
        //             Target.Text += "&lt;";
        //             break;
        //
        //         case '>' :
        //            Target.Text += "&gt;";
        //            break;
        //         
        //         case '&' :
        //             Target.Text += "&amp;";
        //             break;
        //         
        //         case '\"' :
        //             Target.Text += "&#34;";
        //             break;
        //         
        //         case '\'' :
        //             Target.Text += "&#39;";
        //             break;
        //             
        //         default:
        //         Target.Text += current;
        //             break;
        //     }
        // }

        private void CopyOne(char current)
        {
            Target.Text += current switch
            {
                '<' => "&lt;",
                '>' => "&gt;",
                '&' => "&amp;",
                '\"' => "&#34;",
                '\'' => "&#39;",
                _ => current
            };
        }
    }
}
