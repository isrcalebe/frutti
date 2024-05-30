using osu.Framework.Graphics.Shapes;

namespace frutti.Game;

public partial class FruttiGame : FruttiGameBase
{
    private DependencyContainer? dependencies;

    private Box? box;

    [BackgroundDependencyLoader]
    private void load()
    {
        Host.Window.Title = "FRUTTI";

        Add(box = new Box
        {
            Anchor = Anchor.Centre,
            Origin = Anchor.Centre,
            Size = new Vector2(256.0f),
            EdgeSmoothness = new Vector2(2.0f),
            Colour = Colour4.FromHex("E02041")
        });
    }

    protected override void LoadComplete()
    {
        box?.RotateTo(0.0f).Then()
           .RotateTo(360.0f, 2000.0d).Loop();

        base.LoadComplete();
    }

    protected override IReadOnlyDependencyContainer CreateChildDependencies(IReadOnlyDependencyContainer parent)
        => dependencies = new DependencyContainer(base.CreateChildDependencies(parent));
}
