using frutti.Game.Tests;
using osu.Framework;

using var host = Host.GetSuitableDesktopHost("visual-tests", new HostOptions
{
    PortableInstallation = true
});
using var browser = new FruttiGameTestBrowser();

host.Run(browser);
