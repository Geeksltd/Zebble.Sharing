
using Android.Content;
using Android.Net;
using AndroidX.Core.Content;
using Java.IO;

namespace Zebble.Device
{
    public partial class Sharing
    {
        public partial class Instagram
        {
            public static void ShareFile(string url, string title)
            {
                var shareIntent = new Intent(Intent.ActionSend);
                shareIntent.SetType("image/*");
                shareIntent.PutExtra(Intent.ExtraTitle, title);

                File myFiles = new File(url);
                Uri doneUri = FileProvider.GetUriForFile(UIRuntime.CurrentActivity.ApplicationContext,
                        UIRuntime.CurrentActivity.PackageName + ".fileprovider", myFiles);

                shareIntent.PutExtra(Intent.ExtraStream, doneUri);
                shareIntent.SetPackage("com.instagram.android");
                UIRuntime.CurrentActivity.StartActivity(shareIntent);
            }
        }
    }
}
