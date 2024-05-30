using osu.Framework.Android;
using Android.App;
using frutti.Game;

namespace frutti.Android;

[Activity(
    ConfigurationChanges = DEFAULT_CONFIG_CHANGES,
    LaunchMode = DEFAULT_LAUNCH_MODE,
    Exported = true,
    MainLauncher = true)]
public class FruttiGameActivity : AndroidGameActivity
{
    protected override osu.Framework.Game CreateGame()
        => new FruttiGame();
}
