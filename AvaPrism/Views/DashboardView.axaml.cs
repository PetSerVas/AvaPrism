using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace AvaPrism.Views;
public partial class DashboardView : UserControl
{
    public DashboardView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
