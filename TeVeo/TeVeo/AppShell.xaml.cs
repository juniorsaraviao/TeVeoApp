using System;
using System.Collections.Generic;
using TeVeo.ViewModels;
using TeVeo.Views;
using Xamarin.Forms;

namespace TeVeo
{
   public partial class AppShell : Xamarin.Forms.Shell
   {
      public AppShell()
      {
         InitializeComponent();
         Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
         Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
      }

      private async void OnMenuItemClicked(object sender, EventArgs e)
      {
         await Shell.Current.GoToAsync("//LoginPage");
      }
   }
}
