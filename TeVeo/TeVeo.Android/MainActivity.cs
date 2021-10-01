
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android;
using Android.Gms.Common;
using Android.Widget;
using Plugin.FirebasePushNotification;

namespace TeVeo.Droid
{
   [Activity(Label = "TeVeo", Icon = "@mipmap/teveo", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        static readonly string TAG = "MainActivity"; 
        internal static readonly string CHANNEL_ID = "my_notification_channel";
        internal static readonly int NOTIFICATION_ID = 100;
        
        const int RequestLocationId = 0;

        readonly string[] LocationPermissions =
        {
            Manifest.Permission.AccessCoarseLocation,
            Manifest.Permission.AccessFineLocation
        };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //IsPlayServicesAvailable(); //You can use this method to check if play services are available.
            //CreateNotificationChannel();
            
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //Xamarin.FormsMaps.Init(this, savedInstanceState);
            Xamarin.FormsGoogleMaps.Init(this, savedInstanceState);
            LoadApplication(new App());
            Window.SetStatusBarColor(Android.Graphics.Color.Rgb(10, 16, 33));
            Window.SetNavigationBarColor(Android.Graphics.Color.Rgb(10, 16, 33));
            FirebasePushNotificationManager.ProcessIntent(this, Intent);
        }

        protected override void OnStart()
        {
           base.OnStart();
           if ((int)Build.VERSION.SdkInt >= 23)
           {
              if (CheckSelfPermission(Manifest.Permission.AccessFineLocation) != Permission.Granted)
              {
                 RequestPermissions(LocationPermissions, RequestLocationId);
              }
              else
              {
                 // Permissions already granted - display a message.
              }
           }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public bool CheckForGoogleServices()
        {
            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (resultCode != ConnectionResult.Success)
            {
                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                {
                    Toast.MakeText(this, GoogleApiAvailability.Instance.GetErrorString(resultCode), ToastLength.Long);
                }
                else
                {
                    Toast.MakeText(this, "This device does not support Google Play Services", ToastLength.Long);
                }
                return false;
            }
            return true;
        }

        public bool IsPlayServicesAvailable()
        {
           int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this); if (resultCode != ConnectionResult.Success)
           {
              if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                  GoogleApiAvailability.Instance.GetErrorString(resultCode);
              else
              {
                 //This device is not supported           
                 Finish(); // Kill the activity if you want.         
              }
              return false;
           }
           else
           {
              //Google Play Services is available.         
              return true;
           }
        }
        void CreateNotificationChannel()
        {
           if (Build.VERSION.SdkInt < BuildVersionCodes.O)
           {
              // Notification channels are new in API 26 (and not a part of the
              // support library). There is no need to create a notification 
              // channel on older versions of Android.
              return;
           }
        
           var channel = new NotificationChannel(CHANNEL_ID, "FCM Notifications", NotificationImportance.Default)
           {
              Description = "Firebase Cloud Messages appear in this channel"
           };
        
           var notificationManager = (NotificationManager)GetSystemService(NotificationService);
           notificationManager.CreateNotificationChannel(channel);
        }
    }
}