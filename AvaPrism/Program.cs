using Avalonia;
using Avalonia.Logging;
using System.Diagnostics.CodeAnalysis;

namespace AvaPrism;
public class Program
{
    public static AppBuilder BuildAvaloniaApp()
    {
        var builder = AppBuilder
            .Configure<App>()
            .UsePlatformDetect()
            .With(new X11PlatformOptions {EnableMultiTouch = true, UseDBusMenu = true, })
            .With(new Win32PlatformOptions
            {
                AllowEglInitialization= true,
            })
            .UseSkia();
#if DEBUG
        builder.LogToTrace(LogEventLevel.Debug, LogArea.Property, LogArea.Layout, LogArea.Binding);
#endif
        return builder;
    }

    [ExcludeFromCodeCoverage]
    static void Main(string[] args)
    {
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }
        
}
