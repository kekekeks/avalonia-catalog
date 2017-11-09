using Avalonia.Logging.Serilog;
using System;
using System.Linq;
using System.Reflection;
using Avalonia;
using System.Linq;
using Avalonia.Logging;

namespace ControlCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .Start<MainWindow>();
        }
        static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<App>().UsePlatformDetect();
    }
}
