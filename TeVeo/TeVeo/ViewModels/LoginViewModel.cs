using System.Threading.Tasks;
using Xamarin.Forms;

namespace TeVeo.ViewModels
{
   public class LoginViewModel : BaseViewModel
   {
      public  Command     LoginCommand { get; }
      private INavigation _navigation;

      public LoginViewModel()
      {
         LoginCommand = new Command(async() => await OnLoginClicked());
      }

      public void InitializaLogin(INavigation navigation)
      {
         _navigation = navigation;
      }

      private async Task OnLoginClicked()
      {
         // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
         await Task.Delay(2000);
         //await Application.Current.MainPage.Navigation.PopAsync();
         Application.Current.MainPage = new AppShell();
      }
   }
}
