//using Android.App;
//using Android.Content;
//using Android.Util;
//using Firebase.Iid;
//using Firebase.Messaging;
//using Xamarin.Essentials;

//namespace TeVeo.Droid
//{
//   [Service]
//   [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
//   [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
//   public class MessagingService : FirebaseMessagingService
//   {
//      const string TAG = "Firebase";

//      public override void OnNewToken(string token)
//      {
//         base.OnNewToken(token);

//         Log.Debug(TAG, "Update Token: " + token);

//         Preferences.Set("TokenFirebase", token);
//      }

//      public override void OnMessageReceived(RemoteMessage message)
//      {

//      }
//   }
//}