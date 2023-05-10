using Android.App;
using Android.Content.PM;
using Avalonia.Android;


namespace Bylines.Messenger.Client.Android;

[Activity(Label = "Bylines.Messenger.Client.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon", LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
public class MainActivity : AvaloniaMainActivity
{
}
