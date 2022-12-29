using Avalonia;
using Avalonia.Markup.Xaml;
using AvaPrism.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System;

namespace AvaPrism;
public partial class App : PrismApplication
{
    public App()
    {
        Console.WriteLine("Constructor()");
    }

    public override void Initialize()
    {
        Console.WriteLine("Initialize()");

        AvaloniaXamlLoader.Load(this);
        base.Initialize();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        Console.WriteLine("RegisterTypes()");

        //Services

        //Views
        //containerRegistry.Register<MainWindow>();

        //Views for Navigation
    }

    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        base.ConfigureModuleCatalog(moduleCatalog);
    }

    protected override IAvaloniaObject CreateShell()
    {
        Console.WriteLine("CreateShell()");
        return Container.Resolve<MainWindow>();
    }

    

   
}
