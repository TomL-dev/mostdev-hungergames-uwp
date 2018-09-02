using mostdev_hungergames_uwp.Views;
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

namespace mostdev_hungergames_uwp
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
		#region Navigation
		private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
		{
			if (args.IsSettingsSelected)
			{
				contentFrame.Navigate(typeof(SettingsPage));
			}
			else
			{
				TextBlock ItemContent = args.SelectedItem as TextBlock;
				if (ItemContent != null)
				{
					switch (ItemContent.Tag)
					{
						case "Nav_Home":
							contentFrame.Navigate(typeof(HomePage));
							break;

						case "Nav_Shop":
							contentFrame.Navigate(typeof(ShopPage));
							break;

						case "Nav_ShopCart":
							contentFrame.Navigate(typeof(CartPage));
							break;

						case "Nav_Message":
							contentFrame.Navigate(typeof(MessagePage));
							break;

						case "Nav_Print":
							contentFrame.Navigate(typeof(PrintPage));
							break;
					}
				}
			}
		}

		private void NavigationView_Loaded(object sender, RoutedEventArgs e)
		{
			// set the initial SelectedItem
			foreach (NavigationViewItemBase item in NavBar.MenuItems)
			{
				if (item is NavigationViewItem && item.Tag.ToString() == "Home_Page")
				{
					NavBar.SelectedItem = item;
					break;
				}
			}
			contentFrame.Navigate(typeof(HomePage));
		}

		private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
		{
			TextBlock ItemContent = args.InvokedItem as TextBlock;
			if (ItemContent != null)
			{
				switch (ItemContent.Tag)
				{
					case "Nav_Home":
						contentFrame.Navigate(typeof(HomePage));
						break;

					case "Nav_Shop":
						contentFrame.Navigate(typeof(ShopPage));
						break;

					case "Nav_ShopCart":
						contentFrame.Navigate(typeof(CartPage));
						break;

					case "Nav_Message":
						contentFrame.Navigate(typeof(MessagePage));
						break;

					case "Nav_Print":
						contentFrame.Navigate(typeof(PrintPage));
						break;
				}
			}
		}
		#endregion
	}
}
