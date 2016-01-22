using Windows.UI.Xaml.Controls;
using Microsoft.WindowsAzure.MobileServices;

namespace fitnessappbackend
{

    public sealed partial class MainPage : Page
    {
         public MainPage()
         {
            this.InitializeComponent();
            MobileServiceClient MobileService = new MobileServiceClient(
             "https://fitnessappbackend-code.azurewebsites.net",
             "loddGNmQdYOJkGLCCYZKZbCtDTybbK85");


         }
        private void startButton_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StartPage), null);
        }

        private void instructionButton_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IntructionsPage), null);
        }

        private void settingsButton_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingsPage), null);
        }

        private void startText_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StartPage), null);
        }
    }
}
