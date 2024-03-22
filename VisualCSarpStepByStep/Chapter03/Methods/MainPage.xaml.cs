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

namespace Methods
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage: Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int leftHandSide = int.Parse(LhsOperand.Text);
                int rightHandSide = int.Parse(RhsOperand.Text);

                int calculatedValue = 0;
                
                if (Addition.IsChecked.HasValue && Addition.IsChecked.Value)
                {
                    calculatedValue = AddValues(leftHandSide, rightHandSide);
                    ShowResult(calculatedValue);
                }
                else if (Subtraction.IsChecked.HasValue && Subtraction.IsChecked.Value)
                {
                    calculatedValue = SubtractValues(leftHandSide, rightHandSide);
                    ShowResult(calculatedValue);
                }
                else if (Multiplication.IsChecked.HasValue && Multiplication.IsChecked.Value)
                {
                    calculatedValue = MultiplyValues(leftHandSide, rightHandSide);
                    ShowResult(calculatedValue);
                }
                else if (Division.IsChecked.HasValue && Division.IsChecked.Value)
                {
                    int division, remainder;
                    (division, remainder) = Divide(leftHandSide, rightHandSide);
                    Result.Text = $"{division} remainder {remainder}";
                }
            }
            catch (Exception caught)
            {
                Expression.Text = "";
                Result.Text = caught.Message;
            }
        }

        private int AddValues(int leftHandSide, int rightHandSide)
        {
            Expression.Text = $"{leftHandSide} + {rightHandSide}";
            return leftHandSide + rightHandSide;
        } 

        private int SubtractValues(int leftHandSide, int rightHandSide)
        {
            Expression.Text = $"{leftHandSide} - {rightHandSide}";
            return leftHandSide - rightHandSide;
        }

        private int MultiplyValues(int leftHandSide, int rightHandSide)
        {
            Expression.Text = $"{leftHandSide} * {rightHandSide}";
            return leftHandSide * rightHandSide;
        }

        private (int, int) Divide(int leftHandSide, int rightHandSide)
        {
            Expression.Text = $"{leftHandSide} / {rightHandSide}";
            int division = leftHandSide / rightHandSide;
            int remainder = leftHandSide % rightHandSide;
            return (division, remainder);
        }
        
        private void ShowResult(int answer) => Result.Text = answer.ToString();
    }
}
