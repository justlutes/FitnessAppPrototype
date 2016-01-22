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
using Microsoft.WindowsAzure.MobileServices;
using System.Runtime.Serialization;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace fitnessappbackend
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartPage : Page
    {
        IMobileServiceTable<Exercises> exercisesTable = App.MobileService.GetTable<Exercises>();      

        public StartPage()
        {
            this.InitializeComponent();
            MobileServiceClient MobileService = new MobileServiceClient(
              "http://fitnessappbackend-code.azurewebsites.net",
              "loddGNmQdYOJkGLCCYZKZbCtDTybbK85");
            

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

        private void completeWorkoutButton_Click(object sender, RoutedEventArgs e)
        {
            squatRepsTextBox.Text = "";
            squatWeightTextBox.Text = "";
            overheadPressRepsTextBox.Text = "";
            overheadPressWeightTextBox.Text = "";
            pullUpRepsTextBox.Text = "";
            pullUpWeightTextBox.Text = "";


            string exercise1 = "Squat";
            string exercise2 = "Overhead Press";
            string exercise3 = "Pull Up";

            Exercises itemsToInsert = new Exercises
            {
                Exercise1Name = exercise1, Exercise1Reps = squatRepsTextBox.Text,
                Exercise1Weight = squatWeightTextBox.Text, Exercise2Name = exercise2, Exercise2Reps = overheadPressRepsTextBox.Text,
                Exercise2Weight = overheadPressWeightTextBox.Text,
                Exercise3Name = exercise3, Exercise3Reps = pullUpRepsTextBox.Text, Exercise3Weight = pullUpWeightTextBox.Text      

            };
            InsertItem(itemsToInsert);

            
        }

        private async void InsertItem(Exercises itemtoinsert)
        {
            try
            {
                await exercisesTable.InsertAsync(itemtoinsert);
            }
            catch
            {

            }
           
        }
    }
}
