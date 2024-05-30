global using osu.Framework.Allocation;
global using osu.Framework.Bindables;
global using osu.Framework.Graphics;
global using osu.Framework.Logging;
global using osu.Framework.Utils;
global using osuTK;
using frutti.Game.Resources;
using osu.Framework.IO.Stores;

namespace frutti.Game;

public abstract partial class FruttiGameBase : osu.Framework.Game
{
    private DependencyContainer? dependencies;

    [BackgroundDependencyLoader]
    private void load()
    {
        Resources.AddStore(new DllResourceStore(FruttiResourceProvider.ASSEMBLY));
    }

    protected override IReadOnlyDependencyContainer CreateChildDependencies(IReadOnlyDependencyContainer parent)
        => dependencies = new DependencyContainer(base.CreateChildDependencies(parent));
}
