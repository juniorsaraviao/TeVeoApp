using System;
using System.Collections.Generic;
using System.Text;
using TeVeo.Models;

namespace TeVeo.ViewModels
{
   public class RaspberryImagesViewModel : BaseViewModel
   {
      public IList<RaspberryImages> ImagesList => RaspberryImages.ReturnImages();
   }
}
