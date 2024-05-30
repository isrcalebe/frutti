global using osu.Framework.Allocation;
global using osu.Framework.Bindables;
global using osu.Framework.Graphics;
global using osu.Framework.Logging;
global using osu.Framework.Testing;
global using osuTK;
global using NUnit.Framework;
using osu.Framework.Graphics.Cursor;

namespace frutti.Game.Tests;

public partial class FruttiGameTestBrowser : FruttiGameBase
{
    protected override void LoadComplete()
    {
        AddRange([
            new TestBrowser("frutti"),
            new CursorContainer()
        ]);

        base.LoadComplete();
    }
}
