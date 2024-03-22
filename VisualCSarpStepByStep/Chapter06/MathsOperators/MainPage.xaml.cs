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

namespace MathsOperators
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CalculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Addition.IsChecked != null && (bool)Addition.IsChecked)
                {
                    AddValues();
                }
                else if (Subtraction.IsChecked != null && (bool)Subtraction.IsChecked)
                {
                    SubtractValues();
                }
                else if (Multiplication.IsChecked != null && (bool)Multiplication.IsChecked)
                {
                    MultiplyValues();
                }
                else if (Division.IsChecked != null && (bool)Division.IsChecked)
                {
                    DivideValues();
                }
                else if (Remainder.IsChecked != null && (bool)Remainder.IsChecked)
                {
                    RemainderValues();
                }
                else
                {
                    throw new InvalidOperationException("No operator selected");
                }
            }
            catch (FormatException fEx)
            {
                Result.Text = fEx.Message;
            }

            catch (OverflowException oEx)
            {
                Result.Text = oEx.Message;
            }
            catch (InvalidOperationException ioEx)
            {
                Result.Text = ioEx.Message;
            }
            catch (Exception ex)
            {
                Result.Text = ex.Message;
            }
        }
        
        private void AddValues()
        {
            int lhs = int.Parse(LhsOperand.Text);
            int rhs = int.Parse(RhsOperand.Text);
            int outcome = 0;

            outcome = lhs + rhs;
            Expression.Text = $"{lhs} + {rhs}";
            Result.Text = outcome.ToString();
        }
        
        private void SubtractValues()
        {
            int lhs = int.Parse(LhsOperand.Text);
            int rhs = int.Parse(RhsOperand.Text);
            int outcome = 0;

            outcome = lhs - rhs;
            Expression.Text = $"{lhs} - {rhs}";
            Result.Text = outcome.ToString();
        }
        
        private void MultiplyValues()
        {
            int lhs = int.Parse(LhsOperand.Text);
            int rhs = int.Parse(RhsOperand.Text);
            int outcome = 0;

            outcome = checked (lhs * rhs);
            Expression.Text = $"{lhs} * {rhs}";
            Result.Text = outcome.ToString();
        }
        
        private void DivideValues()
        {
            int lhs = int.Parse(LhsOperand.Text);
            int rhs = int.Parse(RhsOperand.Text);
            int outcome = 0;

            outcome = lhs / rhs;
            Expression.Text = $"{lhs} / {rhs}";
            Result.Text = outcome.ToString();
        }
        
        private void RemainderValues()
        {
            int lhs = int.Parse(LhsOperand.Text);
            int rhs = int.Parse(RhsOperand.Text);
            int outcome = 0;

            outcome = lhs % rhs;
            Expression.Text = $"{lhs} % {rhs}";
            Result.Text = outcome.ToString();
        }
    }
}
