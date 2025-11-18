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

namespace LandSecure
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            ContentFrame.Navigate(typeof(HomePage));
        }

        // Add this method to your MainPage class to handle the NavigationView.ItemInvoked event.
        private void NavView_ItemInvoked(Windows.UI.Xaml.Controls.NavigationView sender, Windows.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            // TODO: Add your navigation logic here.
            // Example: Navigate to a page based on args.InvokedItem

            var item = args.InvokedItemContainer as NavigationViewItem;
            if (item == null) return;

            string pageTag = item.Tag.ToString();

            switch (pageTag)
            {
                case "HomePage":
                    ContentFrame.Navigate(typeof(HomePage));
                    break;
                case "VerifyPage":
                    ContentFrame.Navigate(typeof(Verifying));
                    break;
                case "SearchLandPage":
                    ContentFrame.Navigate(typeof(LandSearchPage));
                    break;
                case "TransferLandPage":
                    ContentFrame.Navigate(typeof(TransferPage));
                    break;

            }
        }
    }
}
