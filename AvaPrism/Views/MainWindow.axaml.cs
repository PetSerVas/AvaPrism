using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaPrism.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();

#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
