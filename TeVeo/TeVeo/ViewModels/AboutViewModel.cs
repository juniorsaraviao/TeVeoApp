using System;
using System.Threading.Tasks;
using System.Windows.Input;
using TeVeo.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TeVeo.ViewModels
{
   public class AboutViewModel : BaseViewModel
   {
      public ICommand NavigateMapCommand => new Command(async () => await NavigateMap());

      private INavigation _navigation;

      public AboutViewModel()
      {
         
      }

      public void InitAbout(INavigation navigation)
      {
         _navigation = navigation;
      }

      private async Task NavigateMap()
      {
         await _navigation.PushAsync( new MapRoute() );
      }
   }
}