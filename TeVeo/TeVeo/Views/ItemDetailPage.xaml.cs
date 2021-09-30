using System.ComponentModel;
using TeVeo.ViewModels;
using Xamarin.Forms;

namespace TeVeo.Views
{
   public partial class ItemDetailPage : ContentPage
   {
      public ItemDetailPage()
      {
         InitializeComponent();
         BindingContext = new ItemDetailViewModel();
      }
   }
}