using Windows.UI.Xaml.Controls;
using Microsoft.WindowsAzure.MobileServices;

namespace fitnessappbackend
{
    public sealed partial class MainPage : Page
    {
        MobileServiceCollection<Exercises> items;

        public MainPage()
        {
            this.InitializeComponent();
            exercisesGridView.ItemsSource = items;
  
        }


        private void latestButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

    }
}
