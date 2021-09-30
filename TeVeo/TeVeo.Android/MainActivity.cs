﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android;
using Firebase.Iid;
using Android.Util;
using Android.Gms.Common;
using Android.Widget;

namespace TeVeo.Droid
{
    //[Service]
    //[IntentFilter(new [] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    //public class FirebaseService : FirebaseInstanceIdService
    //{
    //    const string TAG = "MyFirebaseIIDService";

    //    public override void OnTokenRefresh()
    //    {
    //        var refreshedToken = FirebaseInstanceId.Instance.Token;
    //        Log.Debug(TAG, "Refreshed token: " + refreshedToken);
    //        SendRegistrationToServer(refreshedToken);
    //    }

    //    void SendRegistrationToServer(string token)
    //    {
    //        // Add custom implementation, as needed.
    //    }
    //}

    [Activity(Label = "TeVeo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        const int RequestLocationId = 0;

        readonly string[] LocationPermissions =
        {
            Manifest.Permission.AccessCoarseLocation,
            Manifest.Permission.AccessFineLocation
        };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //Xamarin.FormsMaps.Init(this, savedInstanceState);
            Xamarin.FormsGoogleMaps.Init(this, savedInstanceState);
            LoadApplication(new App());
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

        //public bool CheckForGoogleServices()
        //{
        //    int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
        //    if (resultCode != ConnectionResult.Success)
        //    {
        //        if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
        //        {
        //            Toast.MakeText(this, GoogleApiAvailability.Instance.GetErrorString(resultCode), ToastLength.Long);
        //        }
        //        else
        //        {
        //            Toast.MakeText(this, "This device does not support Google Play Services", ToastLength.Long);
        //        }
        //        return false;
        //    }
        //    return true;
        //}
    }
}