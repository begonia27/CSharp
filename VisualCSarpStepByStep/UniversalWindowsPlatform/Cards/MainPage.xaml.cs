using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Cards
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public const int NumHands = 4;
        private Pack pack = null;
        private Hand[] hands = new Hand[NumHands];
        
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void DealClick(object sender, RoutedEventArgs e)
        {
            try
            {
                pack = new Pack();

                for (int handNum = 0; handNum < NumHands; handNum++)
                {
                    hands[handNum] = new Hand();
                    for (int numCards = 0; numCards < Hand.HandSize; numCards++)
                    {
                        PlayingCard cardDealt = pack.DealCardFromPack();
                        hands[handNum].AddCardToHand(cardDealt);
                    }
                }

                North.Text = hands[0].ToString();
                South.Text = hands[1].ToString();
                East.Text = hands[2].ToString();
                West.Text = hands[3].ToString();
            }
            catch (Exception exception)
            {
                MessageDialog msg = new MessageDialog(exception.Message, "Error");
                _ = msg.ShowAsync();
            }
        }
    }
}
