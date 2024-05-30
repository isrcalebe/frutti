using frutti.Game;
using osu.Framework.Allocation;
using osu.Framework.Platform;

namespace frutti.Android;

public partial class FruttiGameAndroid(FruttiGameActivity activity) : FruttiGame
{
    [Cached]
    private readonly FruttiGameActivity activity = activity;

    protected override void LoadComplete()
    {
        base.LoadComplete();

        LoadComponentAsync(new GameplayScreenRotationLocker());
    }

    public override void SetHost(GameHost host)
    {
        base.SetHost(host);

        host.Window.CursorState |= CursorState.Hidden;
    }
}
