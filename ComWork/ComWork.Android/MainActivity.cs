using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using System.Net.Http;
using System.Net.Http.Headers;
using Android.Widget;
using Foundation;

namespace ComWork.Droid
{
    [Activity(Label = "ComWork", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
//public class MainActivity : Activity
//{
//    EditText txtusername;
//    EditText txtPassword;
//    Button btncreate;
//    Button btnsign;

//    private async void Btnsign_Click(object sender, EventArgs e)
//    {
//        HttpClient client = new HttpClient();
//        var uri = new Uri(string.Format("http://xamarinlogin.azurewebsites.net/api/Login?username=" + txtusername.Text + "&password=" + txtPassword.Text));
//        HttpResponseMessage response; ;
//        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//        response = await client.GetAsync(uri);
//        if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
//        {
//            var errorMessage1 = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
//            {
//                '"'
//            });
//            Toast.MakeText(this, errorMessage1, ToastLength.Long).Show();
//        }
//        else
//        {
//            var errorMessage1 = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
//            {
//                '"'
//            });
//            Toast.MakeText(this, errorMessage1, ToastLength.Long).Show();
//        }
//    }
//    private void Btncreate_Click(object sender, EventArgs e)
//    {
//        StartActivity(typeof(NSUserActivity));
//    }
//}
