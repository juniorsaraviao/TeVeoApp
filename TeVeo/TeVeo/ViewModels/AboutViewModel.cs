using Plugin.LocalNotifications;
using System;
using System.Linq;
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
      public ICommand BluetoothCommand   => new Command(async () => await DisplayBluetoothMessage());
      public ICommand ImagesCommand      => new Command(async () => await NavigateImagesPage());

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

      private async Task DisplayBluetoothMessage()
      {
         await Application.Current.MainPage.DisplayAlert("Bluetooth Activado", "Se ha establecido conexión con el raspberry", "Ok");
      }

      private async Task NavigateImagesPage()
      {
         await _navigation.PushAsync(new RaspberryImagesPage());
      }

      public async Task TextToSpeechPlay()
      {
         await Task.Delay(8000);
         CrossLocalNotifications.Current.Show("TeVeo en este momento", "Ciclista1 cerca, cuidado!", 0, DateTime.Now.AddSeconds(7));
      }
   }
}