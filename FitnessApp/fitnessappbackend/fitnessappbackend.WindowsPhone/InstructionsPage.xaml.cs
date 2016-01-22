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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace fitnessappbackend
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IntructionsPage : Page
    {
        public IntructionsPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            aboutTitleTextBlock.Visibility = Windows.UI.Xaml.Visibility.Visible;
            aboutParagraphTextBlock.Visibility = Windows.UI.Xaml.Visibility.Visible;
            exerciseListTextBlock.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ExersiseGrid.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            
        }

        private void exercisesButton_Click(object sender, RoutedEventArgs e)
        {
            aboutTitleTextBlock.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            aboutParagraphTextBlock.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            exerciseListTextBlock.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ExersiseGrid.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }
    }
}
