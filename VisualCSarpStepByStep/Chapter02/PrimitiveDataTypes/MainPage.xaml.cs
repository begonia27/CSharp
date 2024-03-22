using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace PrimitiveDataTypes
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

        private void TypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedType = (type.SelectedItem as ListBoxItem);
            switch (selectedType.Content.ToString())
            {
                case "int":
                    ShowIntValue();
                    break;
                case "long":
                    ShowLongValue();
                    break;
                case "float":
                    ShowFloatValue();
                    break;
                case "double":
                    ShowDoubleValue();
                    break;
                case "decimal":
                    ShowDecimalValue();
                    break;
                case "string":
                    ShowStringValue();
                    break;
                case "char":
                    ShowCharValue();
                    break;
                case "bool":
                    ShowBoolValue();
                    break;
            }
        }

        private void ShowIntValue()
        {
            const int intVar = 42;
            value.Text = intVar.ToString();
        }

        private void ShowLongValue()
        {
            const long longVar = 42L;
            value.Text = longVar.ToString();
        }

        private void ShowFloatValue()
        {
            const float floatVar = 0.42F;
            value.Text = floatVar.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowDoubleValue()
        {
            const double doubleVar = 0.42;
            value.Text = doubleVar.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowDecimalValue()
        {
            const decimal decimalVar = 0.42M;
            value.Text = decimalVar.ToString(CultureInfo.InvariantCulture);
        }

        private void ShowStringValue()
        {
            const string stringVar = "forty two";
            value.Text = stringVar;
        }

        private void ShowCharValue()
        {
            const char charVar = 'x';
            value.Text = charVar.ToString();
        }

        private void ShowBoolValue()
        {
            const bool boolVar = false;
            value.Text = boolVar.ToString();
        }
    }
}
