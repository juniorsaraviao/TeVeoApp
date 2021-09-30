using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace TeVeo.Views
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
   public partial class MapRoute : ContentPage
   {
      public MapRoute()
      {
         InitializeComponent();
         SetValues();
         Task task = new Task(() =>
         {
            while (true)
            {
               AddPins();
               Thread.Sleep(1000);
            }
         });
         task.Start();
      }

      private void SetValues()
      {
         var pins = new List<Pin>
         {
             new Pin { Type = PinType.Place, Label = "Auto1", Position = new Position(-12.023832867712366, -77.04939532436336), Icon = BitmapDescriptorFactory.FromBundle("moto2.png") },
             new Pin { Type = PinType.Place, Label = "Auto2", Position = new Position(-12.028177123623715, -77.04435277163107), Icon = BitmapDescriptorFactory.FromBundle("moto2.png") },
             new Pin { Type = PinType.Place, Label = "Auto3", Position = new Position(-12.023497076940671, -77.04958844342656), Icon = BitmapDescriptorFactory.FromBundle("moto2.png") },
         };

         foreach (var pin in pins)
         {            
            map.Pins.Add(pin);
         }
      }

      private void AddPins()
      {         
         var pins = new List<Pin>
         {
             new Pin { Type = PinType.Place, Label = "Auto1", Position = new Position(-12.027841338216115, -77.04478192509887), Icon = BitmapDescriptorFactory.FromBundle("auto.png") },
             new Pin { Type = PinType.Place, Label = "Auto2", Position = new Position(-12.018397202449087, -77.05136943026748), Icon = BitmapDescriptorFactory.FromBundle("auto.png") },
             new Pin { Type = PinType.Place, Label = "Auto3", Position = new Position(-12.018082392217112, -77.05149817629173), Icon = BitmapDescriptorFactory.FromBundle("auto.png") },
         };

         foreach (var pin in pins)
         {
            map.Pins.Add(pin);
         }
      }
   }
}