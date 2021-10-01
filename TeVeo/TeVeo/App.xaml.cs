using Plugin.FirebasePushNotification;
using System;
using TeVeo.Services;
using TeVeo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeVeo
{
   public partial class App : Application
   {

      public App()
      {
         InitializeComponent();

         DependencyService.Register<MockDataStore>();
         MainPage = new AppShell();
         CrossFirebasePushNotification.Current.Subscribe("all");
         CrossFirebasePushNotification.Current.OnTokenRefresh += Current_OnTokenRefresh;
      }

      private void Current_OnTokenRefresh(object source, FirebasePushNotificationTokenEventArgs e)
      {
         System.Diagnostics.Debug.WriteLine($"My token is: {e.Token}");
      }

      protected override void OnStart()
      {
      }

      protected override void OnSleep()
      {
      }

      protected override void OnResume()
      {
      }
   }
}
