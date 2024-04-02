using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
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

namespace Indexers
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private PhoneBook phoneBook = new PhoneBook();
        
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void FindByNameClick(object sender, RoutedEventArgs e)
        {
            string text = Name.Text;

            if (!string.IsNullOrEmpty(text))
            {
                Name personName = new Name(text);
                PhoneNumber personPhoneNumber = phoneBook[personName];
                PhoneNumber.Text = String.IsNullOrEmpty(personPhoneNumber.Text) ? "Not Found" : personPhoneNumber.Text;
            }
        }

        private void FindByPhoneNumberClick(object sender, RoutedEventArgs e)
        {
            string text = PhoneNumber.Text;

            if (!String.IsNullOrEmpty(text))
            {
                PhoneNumber personPhoneNumber = new PhoneNumber(text);
                Name personsName = phoneBook[personPhoneNumber];
                Name.Text = String.IsNullOrEmpty(personsName.Text) ? "Not Found" : personsName.Text;
            }
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(Name.Text) && !String.IsNullOrEmpty(PhoneNumber.Text))
            {
                phoneBook.Add(new Name(Name.Text),
                    new PhoneNumber(PhoneNumber.Text));
                Name.Text = "";
                PhoneNumber.Text = "";
            }
        }
    }
}
