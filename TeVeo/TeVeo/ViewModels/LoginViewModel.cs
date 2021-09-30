using System;
using System.Collections.Generic;
using System.Text;
using TeVeo.Views;
using Xamarin.Forms;

namespace TeVeo.ViewModels
{
   public class LoginViewModel : BaseViewModel
   {
      public Command LoginCommand { get; }

      public LoginViewModel()
      {
         LoginCommand = new Command(OnLoginClicked);
      }

      private void OnLoginClicked()
      {
         // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
         Application.Current.MainPage = new AppShell();
      }
   }
}
