using System;
using System.ComponentModel;
using TeVeo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeVeo.Views
{
   public partial class AboutPage : ContentPage
   {
      public AboutPage()
      {
         InitializeComponent();
      }

      protected override void OnAppearing()
      {
         base.OnAppearing();
         ( (AboutViewModel) BindingContext).InitAbout(Navigation);
      }
   }
}