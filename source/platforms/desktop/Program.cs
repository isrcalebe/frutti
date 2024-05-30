using frutti.Game;
using osu.Framework;

using var host = Host.GetSuitableDesktopHost("frutti", new HostOptions
{
    FriendlyGameName = "FRUTTI",
    PortableInstallation = true
});
using var game = new FruttiGame();

host.Run(game);
