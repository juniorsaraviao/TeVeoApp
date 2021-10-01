using System;
using System.Collections.Generic;
using System.Text;

namespace TeVeo.Models
{
   public class RaspberryImages
   {
      public string ImageName   { get; set; }
      public string ImageSource { get; set; }
      
      public static List<RaspberryImages> ReturnImages()
      {
         return new List<RaspberryImages>
         {
            new RaspberryImages { ImageName = "Foto 2021-09-20T08:50:06 ", ImageSource = "image1" },
            new RaspberryImages { ImageName = "Foto 2021-10-20T11:42:06 ", ImageSource = "image2" },
            new RaspberryImages { ImageName = "Foto 2021-10-20T09:30:06 ", ImageSource = "image3" }
         };
      }
   }
}
