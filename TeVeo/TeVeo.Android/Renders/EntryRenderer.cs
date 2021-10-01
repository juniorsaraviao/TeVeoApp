using Android.Content;
using TeVeo.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
namespace TeVeo.Droid.Renders
{
   class MyEntryRenderer : EntryRenderer
   {
      public MyEntryRenderer(Context context) : base(context)
      {
      }

      protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
      {
         base.OnElementChanged(e);
         if (Control != null)
         {
            Control.SetTextColor(global::Android.Graphics.Color.Black);
            Control.SetBackgroundColor(global::Android.Graphics.Color.White);
         }
      }
   }
}