using osu.Framework.Android;
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace frutti.Android;

[Activity(
    ConfigurationChanges = DEFAULT_CONFIG_CHANGES,
    LaunchMode = DEFAULT_LAUNCH_MODE,
    ScreenOrientation = ScreenOrientation.Landscape,
    Exported = true,
    MainLauncher = true)]
public class FruttiGameActivity : AndroidGameActivity
{
    protected override osu.Framework.Game CreateGame()
        => new FruttiGameAndroid(this);

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        RequestedOrientation = ScreenOrientation.Landscape;
    }
}
