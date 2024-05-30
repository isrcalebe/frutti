using osu.Framework.Platform;

namespace frutti.Game.Tests.Visual.Application;

[TestFixture]
public partial class TestSceneFruttiGame : FruttiTestScene
{
    private FruttiGame? game;

    [BackgroundDependencyLoader]
    private void load(GameHost host)
    {
        game = [];
        game.SetHost(host);

        AddGame(game);
    }
}
