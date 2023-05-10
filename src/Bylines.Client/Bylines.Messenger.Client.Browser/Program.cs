using System.Runtime.Versioning;
using Avalonia.Browser;
using Avalonia.ReactiveUI;

[assembly: SupportedOSPlatform("browser")]

namespace Bylines.Messenger.Client.Browser;

internal partial class Program
{
    private static void Main(string[] args) => BuildAvaloniaApp()
                                               .UseReactiveUI()
                                               .SetupBrowserApp("out");

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>();
}