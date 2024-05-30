using Android.Content.PM;
using osu.Framework.Allocation;
using osu.Framework.Graphics;

namespace frutti.Android;

public partial class GameplayScreenRotationLocker : Component
{
    [BackgroundDependencyLoader]
    private void load(FruttiGameActivity activity)
    {
        activity.RunOnUiThread(() =>
        {
            activity.RequestedOrientation = ScreenOrientation.Locked;
        });
    }
}
